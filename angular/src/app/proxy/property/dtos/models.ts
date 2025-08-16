import type { BuildingType } from '../../enums/building-type.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdatePropertyDto {
  code?: string;
  addressLine?: string;
  buildingType?: BuildingType;
  buildingArea?: number;
  floorNumber: number;
  color?: string;
}

export interface PropertyDto extends AuditedEntityDto<string> {
  tenantId?: string;
  code?: string;
  addressLine?: string;
  buildingType?: BuildingType;
  buildingArea: number;
  floorNumber: number;
  color?: string;
}
