namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis elegans
/// NCBI TaxId: 258937
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_elegans : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 258937;
}
