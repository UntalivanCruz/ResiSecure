import { mapEnumToOptions } from '@abp/ng.core';

export enum BuildingType {
  SingleFamilyHome = 0,
  MultiFamilyHome = 1,
  Apartment = 2,
  Condominium = 3,
  Townhouse = 4,
  Duplex = 5,
  Triplex = 6,
  Fourplex = 7,
  MobileHome = 8,
  ModularHome = 9,
  TinyHouse = 10,
  VacationHome = 11,
  MixedUseBuilding = 12,
}

export const buildingTypeOptions = mapEnumToOptions(BuildingType);
