namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Tursiops;

/// <summary>
/// Species: Tursiops sp. TT
/// NCBI TaxId: 3027314
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tursiops_sp_TT : Tursiops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tursiops sp. TT";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tursiops_sp_TT";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3027314;
}
