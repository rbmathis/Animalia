namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus;

/// <summary>
/// Species: Ursus ingressus
/// NCBI TaxId: 518689
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ursus_ingressus : Ursus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ursus ingressus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ursus_ingressus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 518689;
}
