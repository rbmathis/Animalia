namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Myrmecobiidae.Myrmecobius;

/// <summary>
/// Species: Myrmecobius fasciatus
/// NCBI TaxId: 55782
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myrmecobius_fasciatus : Myrmecobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myrmecobius fasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myrmecobius_fasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55782;
}
