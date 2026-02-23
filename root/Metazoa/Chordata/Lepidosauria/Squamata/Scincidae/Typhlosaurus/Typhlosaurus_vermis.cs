namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Typhlosaurus;

/// <summary>
/// Species: Typhlosaurus vermis
/// NCBI TaxId: 156908
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Typhlosaurus_vermis : Typhlosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Typhlosaurus vermis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Typhlosaurus_vermis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 156908;
}
