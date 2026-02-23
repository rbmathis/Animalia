namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Garrulus;

/// <summary>
/// Species: Garrulus lanceolatus
/// NCBI TaxId: 1200962
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Garrulus_lanceolatus : Garrulus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Garrulus lanceolatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Garrulus_lanceolatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1200962;
}
