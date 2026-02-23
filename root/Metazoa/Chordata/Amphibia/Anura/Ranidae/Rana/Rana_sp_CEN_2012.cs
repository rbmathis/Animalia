namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

/// <summary>
/// Species: Rana sp. CEN-2012
/// NCBI TaxId: 1165454
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rana_sp_CEN_2012 : Rana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rana sp. CEN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rana_sp_CEN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1165454;
}
