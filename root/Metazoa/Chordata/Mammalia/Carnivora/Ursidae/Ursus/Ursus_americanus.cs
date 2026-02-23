namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus;

/// <summary>
/// Species: Ursus americanus
/// NCBI TaxId: 9643
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ursus_americanus : Ursus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ursus americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ursus_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9643;
}
