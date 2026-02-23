namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Spelaeornis;

/// <summary>
/// Species: Spelaeornis longicaudatus
/// NCBI TaxId: 1480061
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spelaeornis_longicaudatus : Spelaeornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spelaeornis longicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spelaeornis_longicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1480061;
}
