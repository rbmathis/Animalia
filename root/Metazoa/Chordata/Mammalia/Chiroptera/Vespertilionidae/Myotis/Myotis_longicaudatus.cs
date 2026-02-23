namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis longicaudatus
/// NCBI TaxId: 2794210
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_longicaudatus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis longicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_longicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2794210;
}
