namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Nannopsittaca;

/// <summary>
/// Species: Nannopsittaca panychlora
/// NCBI TaxId: 458120
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nannopsittaca_panychlora : Nannopsittaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nannopsittaca panychlora";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nannopsittaca_panychlora";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 458120;
}
