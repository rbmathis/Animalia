namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Scyliorhinus;

/// <summary>
/// Species: Scyliorhinus canicula
/// NCBI TaxId: 7830
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scyliorhinus_canicula : Scyliorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scyliorhinus canicula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scyliorhinus_canicula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7830;
}
