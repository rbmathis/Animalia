namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cyornis;

/// <summary>
/// Species: Cyornis turcosus
/// NCBI TaxId: 1591020
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyornis_turcosus : Cyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyornis turcosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyornis_turcosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1591020;
}
