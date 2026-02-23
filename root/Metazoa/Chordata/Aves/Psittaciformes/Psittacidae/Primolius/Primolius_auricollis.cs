namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Primolius;

/// <summary>
/// Species: Primolius auricollis
/// NCBI TaxId: 178892
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Primolius_auricollis : Primolius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Primolius auricollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Primolius_auricollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 178892;
}
