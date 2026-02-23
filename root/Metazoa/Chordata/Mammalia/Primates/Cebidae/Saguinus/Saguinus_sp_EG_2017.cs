namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Species: Saguinus sp. EG-2017
/// NCBI TaxId: 1967463
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saguinus_sp_EG_2017 : Saguinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saguinus sp. EG-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saguinus_sp_EG_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1967463;
}
