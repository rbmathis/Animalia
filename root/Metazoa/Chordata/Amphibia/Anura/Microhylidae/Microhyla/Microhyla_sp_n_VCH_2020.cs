namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla sp. n VCH-2020
/// NCBI TaxId: 2759160
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_sp_n_VCH_2020 : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla sp. n VCH-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_sp_n_VCH_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2759160;
}
