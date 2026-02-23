namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hypopachus;

/// <summary>
/// Species: Hypopachus variolosus
/// NCBI TaxId: 445153
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hypopachus_variolosus : Hypopachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hypopachus variolosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hypopachus_variolosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 445153;
}
