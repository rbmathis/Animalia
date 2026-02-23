using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Boinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Boinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2527881
/// </summary>
public abstract class Boinae_intergeneric_hybrids : Boidae, IBoinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2527881;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Boinae_intergeneric_hybrids";
}
