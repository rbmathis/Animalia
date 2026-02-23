namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus;

/// <summary>
/// Species: Ursus spelaeus
/// NCBI TaxId: 39097
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ursus_spelaeus : Ursus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ursus spelaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ursus_spelaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39097;
}
