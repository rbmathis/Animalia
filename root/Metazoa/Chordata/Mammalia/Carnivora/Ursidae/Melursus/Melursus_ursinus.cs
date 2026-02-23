namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Melursus;

/// <summary>
/// Species: Melursus ursinus
/// NCBI TaxId: 9636
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melursus_ursinus : Melursus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melursus ursinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melursus_ursinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9636;
}
