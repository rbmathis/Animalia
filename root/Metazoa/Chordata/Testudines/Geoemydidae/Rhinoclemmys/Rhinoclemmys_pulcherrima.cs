namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Rhinoclemmys;

/// <summary>
/// Species: Rhinoclemmys pulcherrima
/// NCBI TaxId: 260649
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinoclemmys_pulcherrima : Rhinoclemmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinoclemmys pulcherrima";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinoclemmys_pulcherrima";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260649;
}
