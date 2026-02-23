namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sousa;

/// <summary>
/// Species: Sousa sp. HK2
/// NCBI TaxId: 1087187
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sousa_sp_HK2 : Sousa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sousa sp. HK2";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sousa_sp_HK2";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1087187;
}
