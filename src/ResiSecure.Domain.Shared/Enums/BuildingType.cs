namespace ResiSecure.Enums;

public enum BuildingType: byte
{
    SingleFamilyHome,  // Detached house for one family
    MultiFamilyHome,   // Building with multiple separate housing units
    Apartment,         // Individual unit in a larger building
    Condominium,       // Individually owned unit in a shared building
    Townhouse,         // Row house sharing walls with neighbors
    Duplex,            // Two-family home sharing a wall
    Triplex,           // Three-family home sharing walls
    Fourplex,          // Four-family home sharing walls
    MobileHome,        // Prefabricated home on a permanent foundation
    ModularHome,       // Factory-built home assembled on-site
    TinyHouse,         // Small, efficient dwelling often on wheels
    VacationHome,      // Secondary residence for holidays or weekends
    MixedUseBuilding   // Combination of residential and commercial spaces
}