namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Rhoptropus;

/// <summary>
/// Species: Rhoptropus biporosus
/// NCBI TaxId: 152587
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhoptropus_biporosus : Rhoptropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhoptropus biporosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhoptropus_biporosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 152587;
}
