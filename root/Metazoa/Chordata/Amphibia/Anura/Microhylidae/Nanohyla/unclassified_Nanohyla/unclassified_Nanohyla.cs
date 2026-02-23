using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Nanohyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Nanohyla.unclassified_Nanohyla;

/// <summary>
/// Abstract class for unclassified Nanohyla (no rank).
/// NCBI TaxId: 2865998
/// </summary>
public abstract class unclassified_Nanohyla : Nanohyla, Iunclassified_Nanohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nanohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2865998;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nanohyla";
}
