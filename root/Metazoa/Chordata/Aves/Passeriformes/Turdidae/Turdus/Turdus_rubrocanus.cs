namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus rubrocanus
/// NCBI TaxId: 357593
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_rubrocanus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus rubrocanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_rubrocanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 357593;
}
