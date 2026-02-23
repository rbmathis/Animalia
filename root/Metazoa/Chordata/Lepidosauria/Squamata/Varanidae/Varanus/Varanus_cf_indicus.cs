namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus cf. indicus
/// NCBI TaxId: 437650
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_cf_indicus : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus cf. indicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_cf_indicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 437650;
}
