namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus sp. AMNH17260
/// NCBI TaxId: 698677
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_sp_AMNH17260 : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus sp. AMNH17260";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_sp_AMNH17260";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 698677;
}
