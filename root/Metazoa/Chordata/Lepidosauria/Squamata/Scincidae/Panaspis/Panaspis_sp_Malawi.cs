namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Panaspis;

/// <summary>
/// Species: Panaspis sp. Malawi
/// NCBI TaxId: 1810314
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Panaspis_sp_Malawi : Panaspis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Panaspis sp. Malawi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Panaspis_sp_Malawi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1810314;
}
