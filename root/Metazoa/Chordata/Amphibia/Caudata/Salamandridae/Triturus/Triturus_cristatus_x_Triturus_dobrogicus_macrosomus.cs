namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Triturus;

/// <summary>
/// Species: Triturus cristatus x Triturus dobrogicus macrosomus
/// NCBI TaxId: 454747
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triturus_cristatus_x_Triturus_dobrogicus_macrosomus : Triturus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triturus cristatus x Triturus dobrogicus macrosomus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triturus_cristatus_x_Triturus_dobrogicus_macrosomus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 454747;
}
