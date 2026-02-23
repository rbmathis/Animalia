namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodon;

/// <summary>
/// Species: Sigmodon hirsutus
/// NCBI TaxId: 262468
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sigmodon_hirsutus : Sigmodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sigmodon hirsutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sigmodon_hirsutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 262468;
}
