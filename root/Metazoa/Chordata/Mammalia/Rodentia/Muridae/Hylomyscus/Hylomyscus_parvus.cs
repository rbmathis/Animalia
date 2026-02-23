namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hylomyscus;

/// <summary>
/// Species: Hylomyscus parvus
/// NCBI TaxId: 209855
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylomyscus_parvus : Hylomyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylomyscus parvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylomyscus_parvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 209855;
}
