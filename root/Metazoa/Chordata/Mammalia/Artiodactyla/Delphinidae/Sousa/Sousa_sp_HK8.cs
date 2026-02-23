namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sousa;

/// <summary>
/// Species: Sousa sp. HK8
/// NCBI TaxId: 1087193
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sousa_sp_HK8 : Sousa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sousa sp. HK8";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sousa_sp_HK8";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1087193;
}
