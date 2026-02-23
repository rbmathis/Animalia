namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Emberiza;

/// <summary>
/// Species: Emberiza schoeniclus
/// NCBI TaxId: 30425
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emberiza_schoeniclus : Emberiza
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emberiza schoeniclus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emberiza_schoeniclus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30425;
}
