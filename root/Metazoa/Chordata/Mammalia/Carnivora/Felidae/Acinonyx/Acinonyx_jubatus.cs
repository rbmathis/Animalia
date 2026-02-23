namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Acinonyx;

/// <summary>
/// Species: Acinonyx jubatus
/// NCBI TaxId: 32536
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acinonyx_jubatus : Acinonyx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acinonyx jubatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acinonyx_jubatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 32536;
}
