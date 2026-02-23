namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Lithobates;

/// <summary>
/// Species: Lithobates sp. Colima
/// NCBI TaxId: 881011
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lithobates_sp_Colima : Lithobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lithobates sp. Colima";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lithobates_sp_Colima";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 881011;
}
