namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Certhia;

/// <summary>
/// Species: Certhia brachydactyla
/// NCBI TaxId: 73330
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Certhia_brachydactyla : Certhia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Certhia brachydactyla";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Certhia_brachydactyla";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 73330;
}
