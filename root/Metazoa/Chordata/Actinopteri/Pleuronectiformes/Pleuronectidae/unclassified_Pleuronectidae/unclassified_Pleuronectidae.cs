using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.unclassified_Pleuronectidae;

/// <summary>
/// Abstract class for unclassified Pleuronectidae (no rank).
/// NCBI TaxId: 1154626
/// </summary>
public abstract class unclassified_Pleuronectidae : Pleuronectidae, Iunclassified_Pleuronectidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pleuronectidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1154626;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pleuronectidae";
}
