namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Tursiops;

/// <summary>
/// Species: Tursiops sp. AN-2005
/// NCBI TaxId: 321137
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tursiops_sp_AN_2005 : Tursiops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tursiops sp. AN-2005";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tursiops_sp_AN_2005";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 321137;
}
