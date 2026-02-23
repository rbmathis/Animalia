using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pleuronectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pleuronectes.unclassified_Pleuronectes;

/// <summary>
/// Abstract class for unclassified Pleuronectes (no rank).
/// NCBI TaxId: 2640450
/// </summary>
public abstract class unclassified_Pleuronectes : Pleuronectes, Iunclassified_Pleuronectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pleuronectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640450;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pleuronectes";
}
