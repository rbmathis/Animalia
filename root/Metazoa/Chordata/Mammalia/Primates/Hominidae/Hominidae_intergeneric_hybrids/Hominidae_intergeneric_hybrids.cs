using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Hominidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Hominidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2883640
/// </summary>
public abstract class Hominidae_intergeneric_hybrids : Hominidae, IHominidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hominidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2883640;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Hominidae_intergeneric_hybrids";
}
