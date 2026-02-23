namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Micromesistius;

/// <summary>
/// Species: Micromesistius environmental sample
/// NCBI TaxId: 1814138
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Micromesistius_environmental_sample : Micromesistius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Micromesistius environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Micromesistius_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814138;
}
