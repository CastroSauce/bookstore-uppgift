const ENV = {
  dev: {
    production: false,
    apiUrl: 'https://localhost:44314/',
  },
};

export const getEnvVars = () => {

  switch (process.env.ENVIROMENT) {

    default:
      return ENV.dev;
  }
};
