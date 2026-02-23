namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Mergus;

/// <summary>
/// Species: Mergus merganser
/// NCBI TaxId: 8880
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mergus_merganser : Mergus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mergus merganser";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mergus_merganser";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8880;
}
