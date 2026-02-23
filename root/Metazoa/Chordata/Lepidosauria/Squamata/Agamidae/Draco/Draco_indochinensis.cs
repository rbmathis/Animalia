namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco indochinensis
/// NCBI TaxId: 162345
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_indochinensis : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco indochinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_indochinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 162345;
}
