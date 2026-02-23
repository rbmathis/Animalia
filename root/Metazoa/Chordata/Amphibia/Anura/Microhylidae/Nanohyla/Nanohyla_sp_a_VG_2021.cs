namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Nanohyla;

/// <summary>
/// Species: Nanohyla sp. a VG-2021
/// NCBI TaxId: 2865999
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nanohyla_sp_a_VG_2021 : Nanohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nanohyla sp. a VG-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nanohyla_sp_a_VG_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2865999;
}
