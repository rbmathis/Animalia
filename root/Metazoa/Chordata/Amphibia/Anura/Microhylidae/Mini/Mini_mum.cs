namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Mini;

/// <summary>
/// Species: Mini mum
/// NCBI TaxId: 3070231
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mini_mum : Mini
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mini mum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mini_mum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3070231;
}
