namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Tursiops;

/// <summary>
/// Species: Tursiops truncatus
/// NCBI TaxId: 9739
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tursiops_truncatus : Tursiops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tursiops truncatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tursiops_truncatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9739;
}
