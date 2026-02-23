namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis armiensis
/// NCBI TaxId: 2785030
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_armiensis : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis armiensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_armiensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2785030;
}
