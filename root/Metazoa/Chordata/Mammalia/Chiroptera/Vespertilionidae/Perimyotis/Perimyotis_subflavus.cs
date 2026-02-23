namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Perimyotis;

/// <summary>
/// Species: Perimyotis subflavus
/// NCBI TaxId: 27672
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perimyotis_subflavus : Perimyotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perimyotis subflavus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perimyotis_subflavus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27672;
}
