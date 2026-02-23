namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pelophylax;

/// <summary>
/// Species: Pelophylax cf. esculentus FB-2006
/// NCBI TaxId: 367677
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelophylax_cf_esculentus_FB_2006 : Pelophylax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelophylax cf. esculentus FB-2006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelophylax_cf_esculentus_FB_2006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 367677;
}
