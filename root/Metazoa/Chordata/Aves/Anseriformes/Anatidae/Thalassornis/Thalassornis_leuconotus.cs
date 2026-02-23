namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Thalassornis;

/// <summary>
/// Species: Thalassornis leuconotus
/// NCBI TaxId: 56306
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thalassornis_leuconotus : Thalassornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thalassornis leuconotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thalassornis_leuconotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56306;
}
