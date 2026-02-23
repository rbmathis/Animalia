namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Species: Saguinus niger
/// NCBI TaxId: 356665
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saguinus_niger : Saguinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saguinus niger";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saguinus_niger";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 356665;
}
