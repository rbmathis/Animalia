namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hydrophylax;

/// <summary>
/// Species: Hydrophylax gracilis
/// NCBI TaxId: 146731
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydrophylax_gracilis : Hydrophylax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydrophylax gracilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydrophylax_gracilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 146731;
}
