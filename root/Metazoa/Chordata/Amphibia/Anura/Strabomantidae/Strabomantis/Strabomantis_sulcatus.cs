namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Strabomantis;

/// <summary>
/// Species: Strabomantis sulcatus
/// NCBI TaxId: 449234
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Strabomantis_sulcatus : Strabomantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Strabomantis sulcatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Strabomantis_sulcatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 449234;
}
