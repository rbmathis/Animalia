namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Rhinophis;

/// <summary>
/// Species: Rhinophis melanoleucus
/// NCBI TaxId: 2799453
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinophis_melanoleucus : Rhinophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinophis melanoleucus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinophis_melanoleucus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2799453;
}
