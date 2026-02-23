namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Panaspis;

/// <summary>
/// Species: Panaspis sp. Limpopo
/// NCBI TaxId: 1810313
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Panaspis_sp_Limpopo : Panaspis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Panaspis sp. Limpopo";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Panaspis_sp_Limpopo";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1810313;
}
