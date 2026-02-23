namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Urocyon;

/// <summary>
/// Species: Urocyon cinereoargenteus
/// NCBI TaxId: 55040
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Urocyon_cinereoargenteus : Urocyon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Urocyon cinereoargenteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Urocyon_cinereoargenteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55040;
}
