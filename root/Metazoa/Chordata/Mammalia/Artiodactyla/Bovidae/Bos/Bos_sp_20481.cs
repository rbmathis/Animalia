namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos sp. 2048.1
/// NCBI TaxId: 1471203
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_sp_20481 : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos sp. 2048.1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_sp_20481";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1471203;
}
