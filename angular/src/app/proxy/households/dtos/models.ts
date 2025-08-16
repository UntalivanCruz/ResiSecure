import type { AuditedEntityDto } from '@abp/ng.core';
import type { Property } from '../../entities/models';

export interface CreateUpdateHouseholdDto {
  name: string;
  propertyId: string;
}

export interface HouseholdDto extends AuditedEntityDto<string> {
  name?: string;
  propertyId?: string;
  property: Property;
}
