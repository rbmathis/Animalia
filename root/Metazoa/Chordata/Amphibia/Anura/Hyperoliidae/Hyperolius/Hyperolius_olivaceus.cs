namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

/// <summary>
/// Species: Hyperolius olivaceus
/// NCBI TaxId: 2016379
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyperolius_olivaceus : Hyperolius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyperolius olivaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyperolius_olivaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2016379;
}
