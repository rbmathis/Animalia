namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae.Coccyzus;

/// <summary>
/// Species: Coccyzus melacoryphus
/// NCBI TaxId: 121390
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coccyzus_melacoryphus : Coccyzus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coccyzus melacoryphus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coccyzus_melacoryphus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121390;
}
