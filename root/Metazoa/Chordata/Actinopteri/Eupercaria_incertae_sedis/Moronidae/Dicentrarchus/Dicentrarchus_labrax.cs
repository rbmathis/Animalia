namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Moronidae.Dicentrarchus;

/// <summary>
/// Species: Dicentrarchus labrax
/// NCBI TaxId: 13489
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dicentrarchus_labrax : Dicentrarchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dicentrarchus labrax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dicentrarchus_labrax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13489;
}
