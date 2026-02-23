namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Telmatobius;

/// <summary>
/// Species: Telmatobius sibiricus
/// NCBI TaxId: 318400
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Telmatobius_sibiricus : Telmatobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Telmatobius sibiricus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Telmatobius_sibiricus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318400;
}
