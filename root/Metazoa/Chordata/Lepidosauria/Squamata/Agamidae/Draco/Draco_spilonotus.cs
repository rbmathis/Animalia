namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco spilonotus
/// NCBI TaxId: 162352
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_spilonotus : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco spilonotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_spilonotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 162352;
}
