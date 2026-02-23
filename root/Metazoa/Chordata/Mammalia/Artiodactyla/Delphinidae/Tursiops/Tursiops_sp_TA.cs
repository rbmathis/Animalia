namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Tursiops;

/// <summary>
/// Species: Tursiops sp. TA
/// NCBI TaxId: 3027313
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tursiops_sp_TA : Tursiops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tursiops sp. TA";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tursiops_sp_TA";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3027313;
}
