namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Garrulus;

/// <summary>
/// Species: Garrulus glandarius
/// NCBI TaxId: 56783
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Garrulus_glandarius : Garrulus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Garrulus glandarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Garrulus_glandarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56783;
}
