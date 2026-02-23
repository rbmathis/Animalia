namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus;

/// <summary>
/// Species: Ursus maritimus
/// NCBI TaxId: 29073
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ursus_maritimus : Ursus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ursus maritimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ursus_maritimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29073;
}
