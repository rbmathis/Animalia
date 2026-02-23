namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Pungitius;

/// <summary>
/// Species: Pungitius vulgaris
/// NCBI TaxId: 3015204
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pungitius_vulgaris : Pungitius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pungitius vulgaris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pungitius_vulgaris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3015204;
}
