namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Chromis;

/// <summary>
/// Species: Chromis iomelas environmental sample
/// NCBI TaxId: 1069885
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chromis_iomelas_environmental_sample : Chromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chromis iomelas environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chromis_iomelas_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1069885;
}
