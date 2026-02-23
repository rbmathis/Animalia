namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Chinchilla;

/// <summary>
/// Species: Chinchilla lanigera
/// NCBI TaxId: 34839
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chinchilla_lanigera : Chinchilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chinchilla lanigera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chinchilla_lanigera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34839;
}
