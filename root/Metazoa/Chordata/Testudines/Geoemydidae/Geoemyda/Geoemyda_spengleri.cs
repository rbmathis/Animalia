namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Geoemyda;

/// <summary>
/// Species: Geoemyda spengleri
/// NCBI TaxId: 74936
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geoemyda_spengleri : Geoemyda
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geoemyda spengleri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geoemyda_spengleri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 74936;
}
