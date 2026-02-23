namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops;

/// <summary>
/// Species: Phrynops hilarii
/// NCBI TaxId: 8463
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynops_hilarii : Phrynops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynops hilarii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynops_hilarii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8463;
}
