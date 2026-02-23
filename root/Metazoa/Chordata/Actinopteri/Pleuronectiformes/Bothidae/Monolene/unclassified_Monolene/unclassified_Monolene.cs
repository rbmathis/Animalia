using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Monolene;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Monolene.unclassified_Monolene;

/// <summary>
/// Abstract class for unclassified Monolene (no rank).
/// NCBI TaxId: 2618614
/// </summary>
public abstract class unclassified_Monolene : Monolene, Iunclassified_Monolene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monolene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618614;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monolene";
}
