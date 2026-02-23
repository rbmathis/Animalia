using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oxymycterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oxymycterus.unclassified_Oxymycterus;

/// <summary>
/// Abstract class for unclassified Oxymycterus (no rank).
/// NCBI TaxId: 2621768
/// </summary>
public abstract class unclassified_Oxymycterus : Oxymycterus, Iunclassified_Oxymycterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oxymycterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621768;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oxymycterus";
}
