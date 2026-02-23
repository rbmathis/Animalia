namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Avahi;

/// <summary>
/// Species: Avahi laniger
/// NCBI TaxId: 122246
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Avahi_laniger : Avahi
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Avahi laniger";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Avahi_laniger";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 122246;
}
