namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis simus
/// NCBI TaxId: 270776
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_simus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis simus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_simus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 270776;
}
