namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae.Coccyzus;

/// <summary>
/// Species: Coccyzus ferrugineus
/// NCBI TaxId: 3054295
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coccyzus_ferrugineus : Coccyzus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coccyzus ferrugineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coccyzus_ferrugineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3054295;
}
