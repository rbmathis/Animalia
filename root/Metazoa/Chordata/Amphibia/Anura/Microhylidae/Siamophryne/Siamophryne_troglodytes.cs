namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Siamophryne;

/// <summary>
/// Species: Siamophryne troglodytes
/// NCBI TaxId: 2107259
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Siamophryne_troglodytes : Siamophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Siamophryne troglodytes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Siamophryne_troglodytes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2107259;
}
