namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis sp. APS 4
/// NCBI TaxId: 2163911
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_sp_APS_4 : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis sp. APS 4";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_sp_APS_4";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2163911;
}
