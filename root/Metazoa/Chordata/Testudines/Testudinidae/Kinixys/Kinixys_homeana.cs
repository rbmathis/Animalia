namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Kinixys;

/// <summary>
/// Species: Kinixys homeana
/// NCBI TaxId: 286005
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinixys_homeana : Kinixys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinixys homeana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinixys_homeana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286005;
}
