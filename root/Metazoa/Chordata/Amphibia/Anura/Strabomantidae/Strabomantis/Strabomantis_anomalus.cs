namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Strabomantis;

/// <summary>
/// Species: Strabomantis anomalus
/// NCBI TaxId: 449232
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Strabomantis_anomalus : Strabomantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Strabomantis anomalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Strabomantis_anomalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 449232;
}
