namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Species: Saguinus oedipus
/// NCBI TaxId: 9490
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saguinus_oedipus : Saguinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saguinus oedipus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saguinus_oedipus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9490;
}
