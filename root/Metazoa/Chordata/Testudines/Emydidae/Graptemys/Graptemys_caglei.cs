namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys caglei
/// NCBI TaxId: 33564
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_caglei : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys caglei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_caglei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33564;
}
