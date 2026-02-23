namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus;

/// <summary>
/// Species: Tapirus sp.
/// NCBI TaxId: 30583
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tapirus_sp : Tapirus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tapirus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tapirus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30583;
}
