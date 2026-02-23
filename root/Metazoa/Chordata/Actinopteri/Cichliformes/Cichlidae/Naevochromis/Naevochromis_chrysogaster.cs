namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Naevochromis;

/// <summary>
/// Species: Naevochromis chrysogaster
/// NCBI TaxId: 2305434
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naevochromis_chrysogaster : Naevochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naevochromis chrysogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naevochromis_chrysogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2305434;
}
