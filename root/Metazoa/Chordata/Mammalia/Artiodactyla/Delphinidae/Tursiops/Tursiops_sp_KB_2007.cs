namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Tursiops;

/// <summary>
/// Species: Tursiops sp. KB-2007
/// NCBI TaxId: 436502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tursiops_sp_KB_2007 : Tursiops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tursiops sp. KB-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tursiops_sp_KB_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 436502;
}
