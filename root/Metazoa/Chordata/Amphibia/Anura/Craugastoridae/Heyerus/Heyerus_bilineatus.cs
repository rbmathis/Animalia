namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Heyerus;

/// <summary>
/// Species: Heyerus bilineatus
/// NCBI TaxId: 2842251
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heyerus_bilineatus : Heyerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heyerus bilineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heyerus_bilineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2842251;
}
