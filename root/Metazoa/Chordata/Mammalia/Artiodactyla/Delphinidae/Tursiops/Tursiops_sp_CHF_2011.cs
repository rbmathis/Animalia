namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Tursiops;

/// <summary>
/// Species: Tursiops sp. CHF-2011
/// NCBI TaxId: 1085636
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tursiops_sp_CHF_2011 : Tursiops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tursiops sp. CHF-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tursiops_sp_CHF_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1085636;
}
