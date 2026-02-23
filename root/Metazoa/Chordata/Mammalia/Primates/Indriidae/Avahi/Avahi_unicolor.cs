namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Avahi;

/// <summary>
/// Species: Avahi unicolor
/// NCBI TaxId: 402239
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Avahi_unicolor : Avahi
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Avahi unicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Avahi_unicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 402239;
}
