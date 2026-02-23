namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Aspidites;

/// <summary>
/// Species: Aspidites melanocephalus
/// NCBI TaxId: 51883
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aspidites_melanocephalus : Aspidites
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aspidites melanocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aspidites_melanocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51883;
}
