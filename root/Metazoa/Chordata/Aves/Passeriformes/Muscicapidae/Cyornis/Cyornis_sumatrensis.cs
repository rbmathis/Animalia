namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cyornis;

/// <summary>
/// Species: Cyornis sumatrensis
/// NCBI TaxId: 3082900
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyornis_sumatrensis : Cyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyornis sumatrensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyornis_sumatrensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3082900;
}
