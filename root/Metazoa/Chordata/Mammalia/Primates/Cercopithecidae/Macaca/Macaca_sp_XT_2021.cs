namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca sp. XT-2021
/// NCBI TaxId: 2838830
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_sp_XT_2021 : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca sp. XT-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_sp_XT_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2838830;
}
