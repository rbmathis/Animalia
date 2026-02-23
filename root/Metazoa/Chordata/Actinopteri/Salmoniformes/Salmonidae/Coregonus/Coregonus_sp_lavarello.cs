namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus sp. 'lavarello'
/// NCBI TaxId: 861772
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_sp_lavarello : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus sp. 'lavarello'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_sp_lavarello";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 861772;
}
