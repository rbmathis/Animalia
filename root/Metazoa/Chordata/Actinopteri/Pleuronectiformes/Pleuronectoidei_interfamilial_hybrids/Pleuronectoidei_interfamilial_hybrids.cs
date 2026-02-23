using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectoidei_interfamilial_hybrids;

/// <summary>
/// Abstract class for Pleuronectoidei interfamilial hybrids (no rank).
/// NCBI TaxId: 3072171
/// </summary>
public abstract class Pleuronectoidei_interfamilial_hybrids : Pleuronectiformes, IPleuronectoidei_interfamilial_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleuronectoidei interfamilial hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3072171;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Pleuronectoidei_interfamilial_hybrids";
}
