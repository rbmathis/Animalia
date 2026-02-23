namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Ocadia;

/// <summary>
/// Species: Ocadia philippeni
/// NCBI TaxId: 260620
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ocadia_philippeni : Ocadia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ocadia philippeni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ocadia_philippeni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260620;
}
