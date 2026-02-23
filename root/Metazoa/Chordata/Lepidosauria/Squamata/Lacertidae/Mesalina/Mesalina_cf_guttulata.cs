namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Mesalina;

/// <summary>
/// Species: Mesalina cf. guttulata
/// NCBI TaxId: 3317295
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesalina_cf_guttulata : Mesalina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesalina cf. guttulata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesalina_cf_guttulata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3317295;
}
