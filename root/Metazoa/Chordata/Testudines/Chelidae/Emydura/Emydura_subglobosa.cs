namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Emydura;

/// <summary>
/// Species: Emydura subglobosa
/// NCBI TaxId: 251359
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emydura_subglobosa : Emydura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emydura subglobosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emydura_subglobosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 251359;
}
