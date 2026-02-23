namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus;

/// <summary>
/// Species: Ursus arctos
/// NCBI TaxId: 9644
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ursus_arctos : Ursus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ursus arctos";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ursus_arctos";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9644;
}
