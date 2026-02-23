namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla sp. 1 VG-2020
/// NCBI TaxId: 2744381
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_sp_1_VG_2020 : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla sp. 1 VG-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_sp_1_VG_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2744381;
}
