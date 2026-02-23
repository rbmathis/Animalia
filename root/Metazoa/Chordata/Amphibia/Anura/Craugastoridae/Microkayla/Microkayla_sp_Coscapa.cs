namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Microkayla;

/// <summary>
/// Species: Microkayla sp. Coscapa
/// NCBI TaxId: 2006966
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microkayla_sp_Coscapa : Microkayla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microkayla sp. Coscapa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microkayla_sp_Coscapa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2006966;
}
