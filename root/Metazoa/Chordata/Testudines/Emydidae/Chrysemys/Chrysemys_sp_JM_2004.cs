namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Chrysemys;

/// <summary>
/// Species: Chrysemys sp. JM-2004
/// NCBI TaxId: 307036
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chrysemys_sp_JM_2004 : Chrysemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chrysemys sp. JM-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chrysemys_sp_JM_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 307036;
}
