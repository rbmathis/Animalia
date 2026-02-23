namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cyclemys;

/// <summary>
/// Species: Cyclemys sp. gemeli
/// NCBI TaxId: 494921
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyclemys_sp_gemeli : Cyclemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyclemys sp. gemeli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyclemys_sp_gemeli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 494921;
}
