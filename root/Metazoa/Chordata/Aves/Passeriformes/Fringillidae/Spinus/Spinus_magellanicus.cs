namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Spinus;

/// <summary>
/// Species: Spinus magellanicus
/// NCBI TaxId: 54768
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spinus_magellanicus : Spinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spinus magellanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spinus_magellanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 54768;
}
