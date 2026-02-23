namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis annectans
/// NCBI TaxId: 265733
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_annectans : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis annectans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_annectans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 265733;
}
