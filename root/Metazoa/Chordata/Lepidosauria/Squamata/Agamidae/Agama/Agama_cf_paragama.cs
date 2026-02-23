namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama cf. paragama
/// NCBI TaxId: 1000948
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_cf_paragama : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama cf. paragama";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_cf_paragama";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1000948;
}
