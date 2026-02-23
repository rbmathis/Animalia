namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Emydura;

/// <summary>
/// Species: Emydura victoriae
/// NCBI TaxId: 578127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emydura_victoriae : Emydura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emydura victoriae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emydura_victoriae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 578127;
}
