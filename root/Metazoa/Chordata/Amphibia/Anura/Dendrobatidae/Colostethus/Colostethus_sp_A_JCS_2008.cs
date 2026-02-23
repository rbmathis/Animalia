namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Colostethus;

/// <summary>
/// Species: Colostethus sp. A JCS-2008
/// NCBI TaxId: 507646
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colostethus_sp_A_JCS_2008 : Colostethus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colostethus sp. A JCS-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colostethus_sp_A_JCS_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 507646;
}
