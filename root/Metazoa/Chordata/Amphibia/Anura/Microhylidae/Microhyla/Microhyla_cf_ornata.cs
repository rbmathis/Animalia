namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla cf. ornata
/// NCBI TaxId: 130766
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_cf_ornata : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla cf. ornata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_cf_ornata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 130766;
}
