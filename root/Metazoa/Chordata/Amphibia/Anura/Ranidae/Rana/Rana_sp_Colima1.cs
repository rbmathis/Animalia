namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

/// <summary>
/// Species: Rana sp. Colima1
/// NCBI TaxId: 200785
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rana_sp_Colima1 : Rana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rana sp. Colima1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rana_sp_Colima1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 200785;
}
