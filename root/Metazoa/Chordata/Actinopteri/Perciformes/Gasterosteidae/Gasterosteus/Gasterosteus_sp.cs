namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Gasterosteus;

/// <summary>
/// Species: Gasterosteus sp.
/// NCBI TaxId: 3455039
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gasterosteus_sp : Gasterosteus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gasterosteus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gasterosteus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3455039;
}
