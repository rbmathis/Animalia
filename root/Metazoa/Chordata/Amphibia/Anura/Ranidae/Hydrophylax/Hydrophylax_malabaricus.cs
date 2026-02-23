namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hydrophylax;

/// <summary>
/// Species: Hydrophylax malabaricus
/// NCBI TaxId: 267844
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydrophylax_malabaricus : Hydrophylax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydrophylax malabaricus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydrophylax_malabaricus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 267844;
}
