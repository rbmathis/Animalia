namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Kinosternon;

/// <summary>
/// Species: Kinosternon sonoriense
/// NCBI TaxId: 904203
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinosternon_sonoriense : Kinosternon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinosternon sonoriense";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinosternon_sonoriense";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904203;
}
