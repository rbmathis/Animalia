namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko sp. B CDS-2014
/// NCBI TaxId: 1551634
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_sp_B_CDS_2014 : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko sp. B CDS-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_sp_B_CDS_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1551634;
}
