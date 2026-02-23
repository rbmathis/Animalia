namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Hyalosaurus;

/// <summary>
/// Species: Hyalosaurus koellikeri
/// NCBI TaxId: 102194
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyalosaurus_koellikeri : Hyalosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyalosaurus koellikeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyalosaurus_koellikeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 102194;
}
