namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Species: Aotus sp. MAS-2011
/// NCBI TaxId: 1090913
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aotus_sp_MAS_2011 : Aotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aotus sp. MAS-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aotus_sp_MAS_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1090913;
}
