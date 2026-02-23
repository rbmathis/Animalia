namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Gasterosteus;

/// <summary>
/// Species: Gasterosteus aculeatus
/// NCBI TaxId: 69293
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gasterosteus_aculeatus : Gasterosteus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gasterosteus aculeatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gasterosteus_aculeatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69293;
}
