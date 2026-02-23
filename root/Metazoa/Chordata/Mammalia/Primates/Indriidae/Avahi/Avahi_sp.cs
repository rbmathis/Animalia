namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Avahi;

/// <summary>
/// Species: Avahi sp.
/// NCBI TaxId: 3471686
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Avahi_sp : Avahi
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Avahi sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Avahi_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3471686;
}
