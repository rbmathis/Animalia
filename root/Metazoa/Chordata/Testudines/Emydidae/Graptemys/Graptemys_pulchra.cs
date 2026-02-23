namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys pulchra
/// NCBI TaxId: 33572
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_pulchra : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys pulchra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_pulchra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33572;
}
