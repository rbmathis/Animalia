namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Sander;

/// <summary>
/// Species: Sander canadensis
/// NCBI TaxId: 283034
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sander_canadensis : Sander
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sander canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sander_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 283034;
}
