namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Ichthyaetus;

/// <summary>
/// Species: Ichthyaetus audouinii
/// NCBI TaxId: 1288292
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyaetus_audouinii : Ichthyaetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyaetus audouinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyaetus_audouinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1288292;
}
