namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Scopidae.Scopus;

/// <summary>
/// Species: Scopus umbretta
/// NCBI TaxId: 33581
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scopus_umbretta : Scopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scopus umbretta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scopus_umbretta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33581;
}
