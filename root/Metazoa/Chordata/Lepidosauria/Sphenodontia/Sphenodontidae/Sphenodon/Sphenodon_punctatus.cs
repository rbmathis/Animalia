namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Sphenodontia.Sphenodontidae.Sphenodon;

/// <summary>
/// Species: Sphenodon punctatus
/// NCBI TaxId: 8508
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphenodon_punctatus : Sphenodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphenodon punctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphenodon_punctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8508;
}
