namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Herpetoreas;

/// <summary>
/// Species: Herpetoreas sieboldii
/// NCBI TaxId: 1591001
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Herpetoreas_sieboldii : Herpetoreas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Herpetoreas sieboldii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Herpetoreas_sieboldii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1591001;
}
