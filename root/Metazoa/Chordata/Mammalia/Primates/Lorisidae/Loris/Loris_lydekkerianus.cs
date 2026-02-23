namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Loris;

/// <summary>
/// Species: Loris lydekkerianus
/// NCBI TaxId: 300163
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Loris_lydekkerianus : Loris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Loris lydekkerianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Loris_lydekkerianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 300163;
}
