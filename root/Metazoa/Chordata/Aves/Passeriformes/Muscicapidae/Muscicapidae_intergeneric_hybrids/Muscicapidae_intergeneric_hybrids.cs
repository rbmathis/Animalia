using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Muscicapidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Muscicapidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2527882
/// </summary>
public abstract class Muscicapidae_intergeneric_hybrids : Muscicapidae, IMuscicapidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muscicapidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2527882;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Muscicapidae_intergeneric_hybrids";
}
