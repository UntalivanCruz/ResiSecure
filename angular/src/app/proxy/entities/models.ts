import type { AuditedAggregateRoot } from '../volo/abp/domain/entities/auditing/models';
import type { BuildingType } from '../enums/building-type.enum';

export interface Household extends AuditedAggregateRoot<string> {
  tenantId?: string;
  name?: string;
  propertyId?: string;
  property: Property;
}

export interface Property extends AuditedAggregateRoot<string> {
  tenantId?: string;
  code?: string;
  addressLine?: string;
  buildingType?: BuildingType;
  buildingArea?: number;
  floorNumber: number;
  color?: string;
  households: Household[];
}
