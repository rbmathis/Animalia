namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Phrynosoma;

/// <summary>
/// Species: Phrynosoma blainvillii
/// NCBI TaxId: 372482
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynosoma_blainvillii : Phrynosoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynosoma blainvillii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynosoma_blainvillii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 372482;
}
