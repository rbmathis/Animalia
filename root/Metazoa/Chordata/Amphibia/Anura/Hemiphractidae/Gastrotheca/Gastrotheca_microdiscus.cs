namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Gastrotheca;

/// <summary>
/// Species: Gastrotheca microdiscus
/// NCBI TaxId: 1329500
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gastrotheca_microdiscus : Gastrotheca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gastrotheca microdiscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gastrotheca_microdiscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1329500;
}
