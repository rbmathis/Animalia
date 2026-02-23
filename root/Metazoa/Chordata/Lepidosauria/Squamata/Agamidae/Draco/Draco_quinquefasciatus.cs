namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco quinquefasciatus
/// NCBI TaxId: 89030
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_quinquefasciatus : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco quinquefasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_quinquefasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89030;
}
