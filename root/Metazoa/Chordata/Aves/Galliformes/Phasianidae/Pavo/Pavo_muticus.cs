namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Pavo;

/// <summary>
/// Species: Pavo muticus
/// NCBI TaxId: 9050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pavo_muticus : Pavo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pavo muticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pavo_muticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9050;
}
