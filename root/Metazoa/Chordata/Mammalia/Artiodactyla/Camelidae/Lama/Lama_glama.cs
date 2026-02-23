namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Lama;

/// <summary>
/// Species: Lama glama
/// NCBI TaxId: 9844
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lama_glama : Lama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lama glama";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lama_glama";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9844;
}
