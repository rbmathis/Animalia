namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco blanfordii
/// NCBI TaxId: 89021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_blanfordii : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco blanfordii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_blanfordii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89021;
}
