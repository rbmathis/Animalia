namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Nycticebus;

/// <summary>
/// Species: Nycticebus sp.
/// NCBI TaxId: 108082
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nycticebus_sp : Nycticebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nycticebus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nycticebus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 108082;
}
