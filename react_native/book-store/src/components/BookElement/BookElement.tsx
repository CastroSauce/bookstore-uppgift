import { BookDto } from "../../api/proxy/proxy";
import { DateTime } from "luxon";
import './bookElement.css';

export interface BookElementProps {
    element: BookDto;
    onDelete: (id: string) => void;
}

function BookElement(book : BookElementProps) {
    const {author,id,publishDate,titel} = book.element;

    return (
        <div className="element-card">
            <p className="author">Publicerad : {DateTime.fromISO(publishDate ?? '').toISODate()}</p>
            <p className="author">Författare : {author}</p>
            <p className="title">{titel}</p>
            <button className="remove-item" onClick={() => {
                if(book.onDelete)
                    book.onDelete(id);
            }} >Radera</button>
        </div>
  );
};
export default BookElement;
