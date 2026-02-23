namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys pearlensis
/// NCBI TaxId: 1969995
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_pearlensis : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys pearlensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_pearlensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1969995;
}
