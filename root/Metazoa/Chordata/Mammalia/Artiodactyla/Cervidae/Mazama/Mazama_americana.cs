namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Mazama;

/// <summary>
/// Species: Mazama americana
/// NCBI TaxId: 43334
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mazama_americana : Mazama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mazama americana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mazama_americana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43334;
}
