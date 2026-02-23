namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Species: Aotus sp. PDE-2004
/// NCBI TaxId: 261316
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aotus_sp_PDE_2004 : Aotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aotus sp. PDE-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aotus_sp_PDE_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 261316;
}
