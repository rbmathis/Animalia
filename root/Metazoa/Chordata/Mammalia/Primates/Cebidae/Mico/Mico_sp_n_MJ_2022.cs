namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Mico;

/// <summary>
/// Species: Mico sp. n. MJ-2022
/// NCBI TaxId: 2946523
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mico_sp_n_MJ_2022 : Mico
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mico sp. n. MJ-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mico_sp_n_MJ_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2946523;
}
