namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla sp. Rds 05
/// NCBI TaxId: 356222
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_sp_Rds_05 : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla sp. Rds 05";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_sp_Rds_05";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 356222;
}
