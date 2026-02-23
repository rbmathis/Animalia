namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Varecia;

/// <summary>
/// Species: Varecia variegata
/// NCBI TaxId: 9455
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varecia_variegata : Varecia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varecia variegata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varecia_variegata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9455;
}
