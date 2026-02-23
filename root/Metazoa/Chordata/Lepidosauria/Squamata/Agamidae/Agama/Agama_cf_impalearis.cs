namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama cf. impalearis
/// NCBI TaxId: 1000947
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_cf_impalearis : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama cf. impalearis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_cf_impalearis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1000947;
}
