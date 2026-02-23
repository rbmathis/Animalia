namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Pseudemys;

/// <summary>
/// Species: Pseudemys peninsularis
/// NCBI TaxId: 580248
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudemys_peninsularis : Pseudemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudemys peninsularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudemys_peninsularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 580248;
}
