namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Spelaeornis;

/// <summary>
/// Species: Spelaeornis caudatus
/// NCBI TaxId: 1464053
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spelaeornis_caudatus : Spelaeornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spelaeornis caudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spelaeornis_caudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1464053;
}
