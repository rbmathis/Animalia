namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae.Siganus;

/// <summary>
/// Species: Siganus unimaculatus
/// NCBI TaxId: 215396
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Siganus_unimaculatus : Siganus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Siganus unimaculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Siganus_unimaculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 215396;
}
