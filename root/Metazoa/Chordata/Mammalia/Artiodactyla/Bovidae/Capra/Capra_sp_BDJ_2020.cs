namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra;

/// <summary>
/// Species: Capra sp. BDJ-2020
/// NCBI TaxId: 2759234
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capra_sp_BDJ_2020 : Capra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capra sp. BDJ-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capra_sp_BDJ_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2759234;
}
