using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pleuronectinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Pleuronectinae intergeneric hybrids (no rank).
/// NCBI TaxId: 1088862
/// </summary>
public abstract class Pleuronectinae_intergeneric_hybrids : Pleuronectidae, IPleuronectinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleuronectinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1088862;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Pleuronectinae_intergeneric_hybrids";
}
