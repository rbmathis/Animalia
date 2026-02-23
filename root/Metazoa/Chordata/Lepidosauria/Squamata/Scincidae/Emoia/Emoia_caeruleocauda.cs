namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Emoia;

/// <summary>
/// Species: Emoia caeruleocauda
/// NCBI TaxId: 38245
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emoia_caeruleocauda : Emoia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emoia caeruleocauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emoia_caeruleocauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38245;
}
