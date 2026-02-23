using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustelinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Mustelinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2902006
/// </summary>
public abstract class Mustelinae_intergeneric_hybrids : Mustelidae, IMustelinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mustelinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2902006;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Mustelinae_intergeneric_hybrids";
}
