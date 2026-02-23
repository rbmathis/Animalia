namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco sumatranus
/// NCBI TaxId: 162354
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_sumatranus : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco sumatranus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_sumatranus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 162354;
}
