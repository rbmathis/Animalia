namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Miniopteridae.Miniopterus;

/// <summary>
/// Species: Miniopterus sp. SMG-2014a
/// NCBI TaxId: 1574125
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Miniopterus_sp_SMG_2014a : Miniopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Miniopterus sp. SMG-2014a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Miniopterus_sp_SMG_2014a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1574125;
}
