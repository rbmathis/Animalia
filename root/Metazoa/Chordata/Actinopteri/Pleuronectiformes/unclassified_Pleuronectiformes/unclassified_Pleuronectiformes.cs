using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.unclassified_Pleuronectiformes;

/// <summary>
/// Abstract class for unclassified Pleuronectiformes (no rank).
/// NCBI TaxId: 725659
/// </summary>
public abstract class unclassified_Pleuronectiformes : Pleuronectiformes, Iunclassified_Pleuronectiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pleuronectiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725659;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pleuronectiformes";
}
