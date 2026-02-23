namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis bechsteinii
/// NCBI TaxId: 59462
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_bechsteinii : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis bechsteinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_bechsteinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59462;
}
