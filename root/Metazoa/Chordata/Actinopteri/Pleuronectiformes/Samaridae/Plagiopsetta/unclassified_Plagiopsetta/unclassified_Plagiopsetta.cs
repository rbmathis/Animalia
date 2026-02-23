using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Plagiopsetta;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Plagiopsetta.unclassified_Plagiopsetta;

/// <summary>
/// Abstract class for unclassified Plagiopsetta (no rank).
/// NCBI TaxId: 2665442
/// </summary>
public abstract class unclassified_Plagiopsetta : Plagiopsetta, Iunclassified_Plagiopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plagiopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2665442;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plagiopsetta";
}
