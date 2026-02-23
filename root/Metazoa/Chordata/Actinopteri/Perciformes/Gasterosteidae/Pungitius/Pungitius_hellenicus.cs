namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Pungitius;

/// <summary>
/// Species: Pungitius hellenicus
/// NCBI TaxId: 1483110
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pungitius_hellenicus : Pungitius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pungitius hellenicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pungitius_hellenicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1483110;
}
