namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Luscinia;

/// <summary>
/// Species: Luscinia phaenicuroides
/// NCBI TaxId: 3150094
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Luscinia_phaenicuroides : Luscinia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Luscinia phaenicuroides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Luscinia_phaenicuroides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150094;
}
