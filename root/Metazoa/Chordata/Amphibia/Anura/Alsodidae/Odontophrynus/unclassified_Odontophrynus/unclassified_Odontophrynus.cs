using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Odontophrynus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Odontophrynus.unclassified_Odontophrynus;

/// <summary>
/// Abstract class for unclassified Odontophrynus (no rank).
/// NCBI TaxId: 2636075
/// </summary>
public abstract class unclassified_Odontophrynus : Odontophrynus, Iunclassified_Odontophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odontophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636075;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odontophrynus";
}
