namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Inimicus;

/// <summary>
/// Species: Inimicus caledonicus
/// NCBI TaxId: 2578294
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Inimicus_caledonicus : Inimicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Inimicus caledonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Inimicus_caledonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2578294;
}
