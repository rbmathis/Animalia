using AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Sternotherus;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Sternotherus.unclassified_Sternotherus;

/// <summary>
/// Abstract class for unclassified Sternotherus (no rank).
/// NCBI TaxId: 2636320
/// </summary>
public abstract class unclassified_Sternotherus : Sternotherus, Iunclassified_Sternotherus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sternotherus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636320;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sternotherus";
}
