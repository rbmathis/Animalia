namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko chinensis
/// NCBI TaxId: 515997
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_chinensis : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko chinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_chinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 515997;
}
