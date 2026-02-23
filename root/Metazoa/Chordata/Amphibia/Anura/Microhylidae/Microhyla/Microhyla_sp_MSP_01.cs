namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla sp. MSP 01
/// NCBI TaxId: 2550867
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_sp_MSP_01 : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla sp. MSP 01";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_sp_MSP_01";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2550867;
}
