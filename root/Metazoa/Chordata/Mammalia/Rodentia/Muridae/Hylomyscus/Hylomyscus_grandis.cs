namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hylomyscus;

/// <summary>
/// Species: Hylomyscus grandis
/// NCBI TaxId: 1159790
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylomyscus_grandis : Hylomyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylomyscus grandis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylomyscus_grandis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1159790;
}
