namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saimiri;

/// <summary>
/// Species: Saimiri sp. 3 EG-2017
/// NCBI TaxId: 1967466
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saimiri_sp_3_EG_2017 : Saimiri
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saimiri sp. 3 EG-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saimiri_sp_3_EG_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1967466;
}
