namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Histrionicus;

/// <summary>
/// Species: Histrionicus histrionicus
/// NCBI TaxId: 68165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Histrionicus_histrionicus : Histrionicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Histrionicus histrionicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Histrionicus_histrionicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68165;
}
