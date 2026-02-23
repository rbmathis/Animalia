namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Scyliorhinus;

/// <summary>
/// Species: Scyliorhinus capensis
/// NCBI TaxId: 1003802
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scyliorhinus_capensis : Scyliorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scyliorhinus capensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scyliorhinus_capensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003802;
}
