namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco volans
/// NCBI TaxId: 89032
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_volans : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco volans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_volans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89032;
}
