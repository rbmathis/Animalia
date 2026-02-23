namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Rhinophis;

/// <summary>
/// Species: Rhinophis cf. philippinus
/// NCBI TaxId: 2976566
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinophis_cf_philippinus : Rhinophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinophis cf. philippinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinophis_cf_philippinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2976566;
}
