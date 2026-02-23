namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Species: Saguinus sp. TMDSU
/// NCBI TaxId: 2931050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saguinus_sp_TMDSU : Saguinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saguinus sp. TMDSU";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saguinus_sp_TMDSU";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2931050;
}
