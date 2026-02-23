namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oreochromis;

/// <summary>
/// Species: Oreochromis sp. GIFT strain
/// NCBI TaxId: 2315963
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreochromis_sp_GIFT_strain : Oreochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreochromis sp. GIFT strain";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreochromis_sp_GIFT_strain";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2315963;
}
