namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops;

/// <summary>
/// Species: Phrynops sp. FFM-2003
/// NCBI TaxId: 241401
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynops_sp_FFM_2003 : Phrynops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynops sp. FFM-2003";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynops_sp_FFM_2003";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241401;
}
