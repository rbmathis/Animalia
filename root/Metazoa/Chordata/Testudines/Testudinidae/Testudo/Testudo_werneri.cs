namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Testudo;

/// <summary>
/// Species: Testudo werneri
/// NCBI TaxId: 415943
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Testudo_werneri : Testudo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Testudo werneri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Testudo_werneri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 415943;
}
