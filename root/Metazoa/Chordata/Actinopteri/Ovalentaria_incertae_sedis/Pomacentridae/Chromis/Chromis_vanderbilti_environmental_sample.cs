namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Chromis;

/// <summary>
/// Species: Chromis vanderbilti environmental sample
/// NCBI TaxId: 1069886
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chromis_vanderbilti_environmental_sample : Chromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chromis vanderbilti environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chromis_vanderbilti_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1069886;
}
