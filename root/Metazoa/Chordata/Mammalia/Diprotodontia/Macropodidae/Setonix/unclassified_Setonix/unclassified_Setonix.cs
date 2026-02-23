using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Setonix;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Setonix.unclassified_Setonix;

/// <summary>
/// Abstract class for unclassified Setonix (no rank).
/// NCBI TaxId: 2649077
/// </summary>
public abstract class unclassified_Setonix : Setonix, Iunclassified_Setonix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Setonix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649077;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Setonix";
}
