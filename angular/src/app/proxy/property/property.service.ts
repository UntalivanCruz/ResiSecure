import type { CreateUpdatePropertyDto, PropertyDto } from './dtos/models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PropertyService {
  apiName = 'Default';
  

  create = (input: CreateUpdatePropertyDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PropertyDto>({
      method: 'POST',
      url: '/api/app/property',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/property/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PropertyDto>({
      method: 'GET',
      url: `/api/app/property/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<PropertyDto>>({
      method: 'GET',
      url: '/api/app/property',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdatePropertyDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PropertyDto>({
      method: 'PUT',
      url: `/api/app/property/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
