namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser;

/// <summary>
/// Species: Anser rossii
/// NCBI TaxId: 56281
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anser_rossii : Anser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anser rossii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anser_rossii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56281;
}
