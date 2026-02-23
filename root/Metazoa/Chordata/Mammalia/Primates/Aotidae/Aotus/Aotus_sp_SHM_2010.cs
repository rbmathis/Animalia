namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Species: Aotus sp. SHM-2010
/// NCBI TaxId: 940829
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aotus_sp_SHM_2010 : Aotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aotus sp. SHM-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aotus_sp_SHM_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 940829;
}
