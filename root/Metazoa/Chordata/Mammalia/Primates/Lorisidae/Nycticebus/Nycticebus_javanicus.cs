namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Nycticebus;

/// <summary>
/// Species: Nycticebus javanicus
/// NCBI TaxId: 310934
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nycticebus_javanicus : Nycticebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nycticebus javanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nycticebus_javanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 310934;
}
