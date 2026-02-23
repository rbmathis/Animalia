namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Kinixys;

/// <summary>
/// Species: Kinixys zombensis
/// NCBI TaxId: 1145085
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinixys_zombensis : Kinixys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinixys zombensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinixys_zombensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1145085;
}
