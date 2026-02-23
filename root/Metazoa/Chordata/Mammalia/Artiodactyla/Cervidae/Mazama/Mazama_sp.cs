namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Mazama;

/// <summary>
/// Species: Mazama sp.
/// NCBI TaxId: 74479
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mazama_sp : Mazama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mazama sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mazama_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 74479;
}
