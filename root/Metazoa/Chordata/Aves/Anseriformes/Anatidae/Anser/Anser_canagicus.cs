namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser;

/// <summary>
/// Species: Anser canagicus
/// NCBI TaxId: 107021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anser_canagicus : Anser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anser canagicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anser_canagicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 107021;
}
