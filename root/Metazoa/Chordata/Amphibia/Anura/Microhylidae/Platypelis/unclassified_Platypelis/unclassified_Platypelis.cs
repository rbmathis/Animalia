using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Platypelis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Platypelis.unclassified_Platypelis;

/// <summary>
/// Abstract class for unclassified Platypelis (no rank).
/// NCBI TaxId: 2620901
/// </summary>
public abstract class unclassified_Platypelis : Platypelis, Iunclassified_Platypelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platypelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620901;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platypelis";
}
