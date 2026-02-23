namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Artamus;

/// <summary>
/// Species: Artamus fuscus
/// NCBI TaxId: 1200958
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Artamus_fuscus : Artamus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Artamus fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Artamus_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1200958;
}
