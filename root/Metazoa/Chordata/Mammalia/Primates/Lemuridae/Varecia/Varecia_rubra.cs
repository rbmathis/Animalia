namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Varecia;

/// <summary>
/// Species: Varecia rubra
/// NCBI TaxId: 554167
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varecia_rubra : Varecia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varecia rubra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varecia_rubra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 554167;
}
