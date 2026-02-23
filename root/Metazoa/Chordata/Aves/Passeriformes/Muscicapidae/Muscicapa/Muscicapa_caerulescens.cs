namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Muscicapa;

/// <summary>
/// Species: Muscicapa caerulescens
/// NCBI TaxId: 228303
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muscicapa_caerulescens : Muscicapa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muscicapa caerulescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muscicapa_caerulescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 228303;
}
