import type { CreateUpdateHouseholdDto, HouseholdDto } from './dtos/models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class HouseholdService {
  apiName = 'Default';
  

  create = (input: CreateUpdateHouseholdDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, HouseholdDto>({
      method: 'POST',
      url: '/api/app/household',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/household/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, HouseholdDto>({
      method: 'GET',
      url: `/api/app/household/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<HouseholdDto>>({
      method: 'GET',
      url: '/api/app/household',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdateHouseholdDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, HouseholdDto>({
      method: 'PUT',
      url: `/api/app/household/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
