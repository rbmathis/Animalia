namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Chaetophractus;

/// <summary>
/// Species: Chaetophractus vellerosus
/// NCBI TaxId: 340076
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chaetophractus_vellerosus : Chaetophractus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chaetophractus vellerosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chaetophractus_vellerosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 340076;
}
