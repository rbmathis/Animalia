namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Leontopithecus;

/// <summary>
/// Species: Leontopithecus chrysopygus
/// NCBI TaxId: 58710
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leontopithecus_chrysopygus : Leontopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leontopithecus chrysopygus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leontopithecus_chrysopygus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 58710;
}
