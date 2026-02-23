namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Dendrobates;

/// <summary>
/// Species: Dendrobates tinctorius
/// NCBI TaxId: 92724
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendrobates_tinctorius : Dendrobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendrobates tinctorius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendrobates_tinctorius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 92724;
}
