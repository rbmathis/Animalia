namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco obscurus
/// NCBI TaxId: 89029
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_obscurus : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco obscurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_obscurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89029;
}
