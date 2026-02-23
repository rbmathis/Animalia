namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Kinixys;

/// <summary>
/// Species: Kinixys natalensis
/// NCBI TaxId: 286025
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinixys_natalensis : Kinixys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinixys natalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinixys_natalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286025;
}
