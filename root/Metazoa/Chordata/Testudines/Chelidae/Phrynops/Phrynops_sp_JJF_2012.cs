namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops;

/// <summary>
/// Species: Phrynops sp. JJF-2012
/// NCBI TaxId: 1227505
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynops_sp_JJF_2012 : Phrynops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynops sp. JJF-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynops_sp_JJF_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1227505;
}
