namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Phrynosoma;

/// <summary>
/// Species: Phrynosoma douglasii
/// NCBI TaxId: 43611
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynosoma_douglasii : Phrynosoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynosoma douglasii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynosoma_douglasii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43611;
}
