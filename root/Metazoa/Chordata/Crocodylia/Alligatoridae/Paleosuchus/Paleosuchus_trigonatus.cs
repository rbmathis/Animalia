namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Paleosuchus;

/// <summary>
/// Species: Paleosuchus trigonatus
/// NCBI TaxId: 38658
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paleosuchus_trigonatus : Paleosuchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paleosuchus trigonatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paleosuchus_trigonatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38658;
}
