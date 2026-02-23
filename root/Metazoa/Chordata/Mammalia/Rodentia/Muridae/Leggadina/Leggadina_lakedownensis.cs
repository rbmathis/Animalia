namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leggadina;

/// <summary>
/// Species: Leggadina lakedownensis
/// NCBI TaxId: 81936
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leggadina_lakedownensis : Leggadina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leggadina lakedownensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leggadina_lakedownensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 81936;
}
