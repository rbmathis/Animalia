namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Anodonthyla;

/// <summary>
/// Species: Anodonthyla sp. RODS-2018
/// NCBI TaxId: 2316502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anodonthyla_sp_RODS_2018 : Anodonthyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anodonthyla sp. RODS-2018";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anodonthyla_sp_RODS_2018";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2316502;
}
