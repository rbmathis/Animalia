namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Kinixys;

/// <summary>
/// Species: Kinixys lobatsiana
/// NCBI TaxId: 1145087
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinixys_lobatsiana : Kinixys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinixys lobatsiana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinixys_lobatsiana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1145087;
}
