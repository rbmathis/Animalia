namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

/// <summary>
/// Species: Aotus trivirgatus
/// NCBI TaxId: 9505
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aotus_trivirgatus : Aotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aotus trivirgatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aotus_trivirgatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9505;
}
