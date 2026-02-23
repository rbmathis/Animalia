namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Sebastes;

/// <summary>
/// Species: Sebastes spp. 'mixed pool'
/// NCBI TaxId: 98223
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sebastes_spp_mixed_pool : Sebastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sebastes spp. 'mixed pool'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sebastes_spp_mixed_pool";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 98223;
}
