namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus;

/// <summary>
/// Species: Ursus sp. Shennongjia white bear
/// NCBI TaxId: 373678
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ursus_sp_Shennongjia_white_bear : Ursus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ursus sp. Shennongjia white bear";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ursus_sp_Shennongjia_white_bear";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 373678;
}
