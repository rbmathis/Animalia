namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Triprion;

/// <summary>
/// Species: Triprion spinosus
/// NCBI TaxId: 2491332
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triprion_spinosus : Triprion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triprion spinosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triprion_spinosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2491332;
}
