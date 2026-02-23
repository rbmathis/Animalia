namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Triaenodon;

/// <summary>
/// Species: Triaenodon obesus
/// NCBI TaxId: 496413
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triaenodon_obesus : Triaenodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triaenodon obesus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triaenodon_obesus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 496413;
}
