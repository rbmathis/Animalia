namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Macrochelys;

/// <summary>
/// Species: Macrochelys suwanniensis
/// NCBI TaxId: 3026461
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macrochelys_suwanniensis : Macrochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macrochelys suwanniensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macrochelys_suwanniensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3026461;
}
