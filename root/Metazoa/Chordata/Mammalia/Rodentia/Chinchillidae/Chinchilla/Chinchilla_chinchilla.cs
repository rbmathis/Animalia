namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Chinchilla;

/// <summary>
/// Species: Chinchilla chinchilla
/// NCBI TaxId: 10152
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chinchilla_chinchilla : Chinchilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chinchilla chinchilla";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chinchilla_chinchilla";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10152;
}
