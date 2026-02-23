namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Kinosternon;

/// <summary>
/// Species: Kinosternon durangoense
/// NCBI TaxId: 142483
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinosternon_durangoense : Kinosternon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinosternon durangoense";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinosternon_durangoense";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 142483;
}
