namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Vulpes;

/// <summary>
/// Species: Vulpes macrotis
/// NCBI TaxId: 9630
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vulpes_macrotis : Vulpes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vulpes macrotis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vulpes_macrotis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9630;
}
