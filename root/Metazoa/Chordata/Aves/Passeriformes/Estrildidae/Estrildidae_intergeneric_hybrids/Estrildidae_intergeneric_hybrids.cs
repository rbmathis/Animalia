using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Estrildidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Estrildidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2835783
/// </summary>
public abstract class Estrildidae_intergeneric_hybrids : Estrildidae, IEstrildidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Estrildidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835783;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Estrildidae_intergeneric_hybrids";
}
