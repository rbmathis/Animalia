namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Simias;

/// <summary>
/// Species: Simias concolor
/// NCBI TaxId: 170207
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Simias_concolor : Simias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Simias concolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Simias_concolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 170207;
}
