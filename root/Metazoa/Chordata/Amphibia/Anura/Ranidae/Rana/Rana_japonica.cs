namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

/// <summary>
/// Species: Rana japonica
/// NCBI TaxId: 8402
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rana_japonica : Rana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rana japonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rana_japonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8402;
}
