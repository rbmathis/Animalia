namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cyornis;

/// <summary>
/// Species: Cyornis magnirostris
/// NCBI TaxId: 1463941
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyornis_magnirostris : Cyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyornis magnirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyornis_magnirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1463941;
}
