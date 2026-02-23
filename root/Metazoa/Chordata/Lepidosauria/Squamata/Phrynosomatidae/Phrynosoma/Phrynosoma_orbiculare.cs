namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Phrynosoma;

/// <summary>
/// Species: Phrynosoma orbiculare
/// NCBI TaxId: 52576
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynosoma_orbiculare : Phrynosoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynosoma orbiculare";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynosoma_orbiculare";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52576;
}
