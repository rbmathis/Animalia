namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Leontopithecus;

/// <summary>
/// Species: Leontopithecus rosalia
/// NCBI TaxId: 30588
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leontopithecus_rosalia : Leontopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leontopithecus rosalia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leontopithecus_rosalia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30588;
}
