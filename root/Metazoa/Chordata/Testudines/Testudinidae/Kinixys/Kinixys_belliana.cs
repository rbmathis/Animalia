namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Kinixys;

/// <summary>
/// Species: Kinixys belliana
/// NCBI TaxId: 286004
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinixys_belliana : Kinixys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinixys belliana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinixys_belliana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286004;
}
