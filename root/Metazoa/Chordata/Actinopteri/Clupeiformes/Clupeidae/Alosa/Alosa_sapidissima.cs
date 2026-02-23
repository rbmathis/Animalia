namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Alosa;

/// <summary>
/// Species: Alosa sapidissima
/// NCBI TaxId: 34773
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alosa_sapidissima : Alosa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alosa sapidissima";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alosa_sapidissima";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34773;
}
