namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Triturus;

/// <summary>
/// Species: Triturus cf. karelinii 'western'
/// NCBI TaxId: 1288479
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triturus_cf_karelinii_western : Triturus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triturus cf. karelinii 'western'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triturus_cf_karelinii_western";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1288479;
}
