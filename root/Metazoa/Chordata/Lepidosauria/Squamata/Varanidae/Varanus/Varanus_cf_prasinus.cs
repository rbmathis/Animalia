namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus cf. prasinus
/// NCBI TaxId: 437651
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_cf_prasinus : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus cf. prasinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_cf_prasinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 437651;
}
