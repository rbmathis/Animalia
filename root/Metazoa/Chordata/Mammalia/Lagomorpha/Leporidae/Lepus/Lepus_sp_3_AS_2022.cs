namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus sp. 3 AS-2022
/// NCBI TaxId: 3003814
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_sp_3_AS_2022 : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus sp. 3 AS-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_sp_3_AS_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3003814;
}
