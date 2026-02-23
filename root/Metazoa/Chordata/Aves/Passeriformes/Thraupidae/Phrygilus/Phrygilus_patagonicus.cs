namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Phrygilus;

/// <summary>
/// Species: Phrygilus patagonicus
/// NCBI TaxId: 555328
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrygilus_patagonicus : Phrygilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrygilus patagonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrygilus_patagonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555328;
}
