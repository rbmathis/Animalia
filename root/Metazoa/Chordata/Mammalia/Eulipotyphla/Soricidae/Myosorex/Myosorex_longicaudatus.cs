namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Myosorex;

/// <summary>
/// Species: Myosorex longicaudatus
/// NCBI TaxId: 548882
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myosorex_longicaudatus : Myosorex
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myosorex longicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myosorex_longicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 548882;
}
