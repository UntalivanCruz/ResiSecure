 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44330/',
  redirectUri: baseUrl,
  clientId: 'ResiSecure_App',
  responseType: 'code',
  scope: 'offline_access ResiSecure',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ResiSecure',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44330',
      rootNamespace: 'ResiSecure',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
