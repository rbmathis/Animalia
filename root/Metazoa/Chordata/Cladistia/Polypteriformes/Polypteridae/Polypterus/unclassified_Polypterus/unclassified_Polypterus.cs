using AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae.Polypterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae.Polypterus.unclassified_Polypterus;

/// <summary>
/// Abstract class for unclassified Polypterus (no rank).
/// NCBI TaxId: 2645020
/// </summary>
public abstract class unclassified_Polypterus : Polypterus, Iunclassified_Polypterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polypterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645020;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polypterus";
}
