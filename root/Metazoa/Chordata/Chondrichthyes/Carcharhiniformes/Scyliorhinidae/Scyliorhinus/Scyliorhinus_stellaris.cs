namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Scyliorhinus;

/// <summary>
/// Species: Scyliorhinus stellaris
/// NCBI TaxId: 68454
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scyliorhinus_stellaris : Scyliorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scyliorhinus stellaris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scyliorhinus_stellaris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68454;
}
