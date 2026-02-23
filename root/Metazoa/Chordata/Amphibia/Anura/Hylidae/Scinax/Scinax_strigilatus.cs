namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax strigilatus
/// NCBI TaxId: 1788292
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_strigilatus : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax strigilatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_strigilatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1788292;
}
