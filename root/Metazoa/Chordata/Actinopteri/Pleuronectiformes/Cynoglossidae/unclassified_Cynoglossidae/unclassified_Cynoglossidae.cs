using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.unclassified_Cynoglossidae;

/// <summary>
/// Abstract class for unclassified Cynoglossidae (no rank).
/// NCBI TaxId: 1781102
/// </summary>
public abstract class unclassified_Cynoglossidae : Cynoglossidae, Iunclassified_Cynoglossidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynoglossidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1781102;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynoglossidae";
}
