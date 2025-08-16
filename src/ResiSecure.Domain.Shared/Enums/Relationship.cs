namespace ResiSecure.Enums;

public enum Relationship: byte
{
    Self,             // The resident themselves
    Spouse,           // Husband or wife
    Child,            // Son or daughter
    Parent,           // Father or mother
    Sibling,          // Brother or sister
    Grandparent,      // Grandfather or grandmother
    Grandchild,       // Grandson or granddaughter
    UncleAunt,        // Uncle or aunt
    NephewNiece,      // Nephew or niece
    Cousin,           // Cousin
    Roommate,         // Shares the same property but not family
    Caregiver,        // Person taking care of someone
    Tenant,           // Renter (lessee)
    Other             // Any other relationship not listed
}