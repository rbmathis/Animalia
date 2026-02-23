namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Leontopithecus;

/// <summary>
/// Species: Leontopithecus chrysomelas
/// NCBI TaxId: 57374
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leontopithecus_chrysomelas : Leontopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leontopithecus chrysomelas";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leontopithecus_chrysomelas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57374;
}
