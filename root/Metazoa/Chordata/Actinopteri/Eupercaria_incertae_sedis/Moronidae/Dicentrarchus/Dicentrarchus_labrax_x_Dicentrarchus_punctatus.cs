namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Moronidae.Dicentrarchus;

/// <summary>
/// Species: Dicentrarchus labrax x Dicentrarchus punctatus
/// NCBI TaxId: 761803
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dicentrarchus_labrax_x_Dicentrarchus_punctatus : Dicentrarchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dicentrarchus labrax x Dicentrarchus punctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dicentrarchus_labrax_x_Dicentrarchus_punctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 761803;
}
