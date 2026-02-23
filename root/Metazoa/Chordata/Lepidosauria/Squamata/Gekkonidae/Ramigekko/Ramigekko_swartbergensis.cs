namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Ramigekko;

/// <summary>
/// Species: Ramigekko swartbergensis
/// NCBI TaxId: 1208000
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ramigekko_swartbergensis : Ramigekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ramigekko swartbergensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ramigekko_swartbergensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1208000;
}
