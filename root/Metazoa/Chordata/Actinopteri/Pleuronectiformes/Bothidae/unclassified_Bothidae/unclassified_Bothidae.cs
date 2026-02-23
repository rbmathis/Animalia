using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.unclassified_Bothidae;

/// <summary>
/// Abstract class for unclassified Bothidae (no rank).
/// NCBI TaxId: 994740
/// </summary>
public abstract class unclassified_Bothidae : Bothidae, Iunclassified_Bothidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bothidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 994740;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bothidae";
}
