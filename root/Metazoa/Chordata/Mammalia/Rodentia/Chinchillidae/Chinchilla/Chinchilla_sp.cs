namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Chinchilla;

/// <summary>
/// Species: Chinchilla sp.
/// NCBI TaxId: 30616
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chinchilla_sp : Chinchilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chinchilla sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chinchilla_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30616;
}
