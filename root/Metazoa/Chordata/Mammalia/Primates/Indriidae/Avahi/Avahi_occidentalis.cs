namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Avahi;

/// <summary>
/// Species: Avahi occidentalis
/// NCBI TaxId: 132108
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Avahi_occidentalis : Avahi
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Avahi occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Avahi_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 132108;
}
