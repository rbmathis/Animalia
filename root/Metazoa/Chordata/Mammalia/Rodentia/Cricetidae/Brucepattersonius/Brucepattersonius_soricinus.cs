namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Brucepattersonius;

/// <summary>
/// Species: Brucepattersonius soricinus
/// NCBI TaxId: 241099
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brucepattersonius_soricinus : Brucepattersonius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brucepattersonius soricinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brucepattersonius_soricinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241099;
}
