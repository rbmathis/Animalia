namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops;

/// <summary>
/// Species: Phrynops tuberosus
/// NCBI TaxId: 2670360
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynops_tuberosus : Phrynops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynops tuberosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynops_tuberosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2670360;
}
