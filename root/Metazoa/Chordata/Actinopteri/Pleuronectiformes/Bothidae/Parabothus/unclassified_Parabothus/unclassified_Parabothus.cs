using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Parabothus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Parabothus.unclassified_Parabothus;

/// <summary>
/// Abstract class for unclassified Parabothus (no rank).
/// NCBI TaxId: 3451250
/// </summary>
public abstract class unclassified_Parabothus : Parabothus, Iunclassified_Parabothus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parabothus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3451250;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parabothus";
}
