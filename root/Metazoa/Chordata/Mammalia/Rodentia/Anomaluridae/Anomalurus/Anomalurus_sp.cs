namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae.Anomalurus;

/// <summary>
/// Species: Anomalurus sp.
/// NCBI TaxId: 101665
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anomalurus_sp : Anomalurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anomalurus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anomalurus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 101665;
}
