namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Pavo;

/// <summary>
/// Species: Pavo cristatus
/// NCBI TaxId: 9049
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pavo_cristatus : Pavo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pavo cristatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pavo_cristatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9049;
}
