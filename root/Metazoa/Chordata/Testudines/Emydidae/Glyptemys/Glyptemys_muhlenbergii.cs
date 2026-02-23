namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Glyptemys;

/// <summary>
/// Species: Glyptemys muhlenbergii
/// NCBI TaxId: 335393
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Glyptemys_muhlenbergii : Glyptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Glyptemys muhlenbergii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Glyptemys_muhlenbergii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 335393;
}
