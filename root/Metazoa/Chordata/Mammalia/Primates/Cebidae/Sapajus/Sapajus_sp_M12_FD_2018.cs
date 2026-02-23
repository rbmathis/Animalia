namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Sapajus;

/// <summary>
/// Species: Sapajus sp. M12 FD-2018
/// NCBI TaxId: 2093839
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sapajus_sp_M12_FD_2018 : Sapajus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sapajus sp. M12 FD-2018";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sapajus_sp_M12_FD_2018";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2093839;
}
