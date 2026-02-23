using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.unclassified_Ilyophinae;

/// <summary>
/// Abstract class for unclassified Ilyophinae (no rank).
/// NCBI TaxId: 2726643
/// </summary>
public abstract class unclassified_Ilyophinae : Synaphobranchidae, Iunclassified_Ilyophinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ilyophinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726643;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ilyophinae";
}
