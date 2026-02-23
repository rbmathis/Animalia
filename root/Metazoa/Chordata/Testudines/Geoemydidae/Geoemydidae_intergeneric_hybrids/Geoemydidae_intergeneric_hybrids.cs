using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Geoemydidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Geoemydidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2527870
/// </summary>
public abstract class Geoemydidae_intergeneric_hybrids : Geoemydidae, IGeoemydidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geoemydidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2527870;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Geoemydidae_intergeneric_hybrids";
}
