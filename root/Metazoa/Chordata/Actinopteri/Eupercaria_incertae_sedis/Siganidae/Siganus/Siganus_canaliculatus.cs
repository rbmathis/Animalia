namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae.Siganus;

/// <summary>
/// Species: Siganus canaliculatus
/// NCBI TaxId: 75042
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Siganus_canaliculatus : Siganus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Siganus canaliculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Siganus_canaliculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75042;
}
