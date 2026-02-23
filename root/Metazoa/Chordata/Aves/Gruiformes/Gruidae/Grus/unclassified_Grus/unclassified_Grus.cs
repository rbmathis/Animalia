using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Grus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Grus.unclassified_Grus;

/// <summary>
/// Abstract class for unclassified Grus (no rank).
/// NCBI TaxId: 2640093
/// </summary>
public abstract class unclassified_Grus : Grus, Iunclassified_Grus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Grus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640093;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Grus";
}
