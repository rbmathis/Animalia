namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Gasterosteus;

/// <summary>
/// Species: Gasterosteus islandicus
/// NCBI TaxId: 1758712
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gasterosteus_islandicus : Gasterosteus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gasterosteus islandicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gasterosteus_islandicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1758712;
}
