namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Kinosternon;

/// <summary>
/// Species: Kinosternon alamosae
/// NCBI TaxId: 904194
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kinosternon_alamosae : Kinosternon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kinosternon alamosae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kinosternon_alamosae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904194;
}
