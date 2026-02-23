namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Geckolepis;

/// <summary>
/// Species: Geckolepis aff. maculata
/// NCBI TaxId: 1934009
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geckolepis_aff_maculata : Geckolepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geckolepis aff. maculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geckolepis_aff_maculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1934009;
}
