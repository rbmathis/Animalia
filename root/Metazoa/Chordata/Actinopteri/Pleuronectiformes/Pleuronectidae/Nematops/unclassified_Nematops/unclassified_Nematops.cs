using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Nematops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Nematops.unclassified_Nematops;

/// <summary>
/// Abstract class for unclassified Nematops (no rank).
/// NCBI TaxId: 2665445
/// </summary>
public abstract class unclassified_Nematops : Nematops, Iunclassified_Nematops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nematops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2665445;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nematops";
}
