namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax rossaferesae
/// NCBI TaxId: 3045585
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_rossaferesae : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax rossaferesae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_rossaferesae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3045585;
}
