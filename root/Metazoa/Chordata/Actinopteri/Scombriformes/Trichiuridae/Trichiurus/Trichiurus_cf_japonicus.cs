namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Trichiurus;

/// <summary>
/// Species: Trichiurus cf. japonicus
/// NCBI TaxId: 3234859
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trichiurus_cf_japonicus : Trichiurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trichiurus cf. japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trichiurus_cf_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3234859;
}
