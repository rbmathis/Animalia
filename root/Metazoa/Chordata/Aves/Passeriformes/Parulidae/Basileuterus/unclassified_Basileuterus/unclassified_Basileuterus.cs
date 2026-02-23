using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Basileuterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Basileuterus.unclassified_Basileuterus;

/// <summary>
/// Abstract class for unclassified Basileuterus (no rank).
/// NCBI TaxId: 3235154
/// </summary>
public abstract class unclassified_Basileuterus : Basileuterus, Iunclassified_Basileuterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Basileuterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3235154;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Basileuterus";
}
