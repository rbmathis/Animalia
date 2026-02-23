namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus sp. 4 VaV-2019
/// NCBI TaxId: 2583795
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_sp_4_VaV_2019 : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus sp. 4 VaV-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_sp_4_VaV_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2583795;
}
