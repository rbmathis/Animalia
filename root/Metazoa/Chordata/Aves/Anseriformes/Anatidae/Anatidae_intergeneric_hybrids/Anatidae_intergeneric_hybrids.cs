using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anatidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Anatidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2823287
/// </summary>
public abstract class Anatidae_intergeneric_hybrids : Anatidae, IAnatidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anatidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823287;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Anatidae_intergeneric_hybrids";
}
