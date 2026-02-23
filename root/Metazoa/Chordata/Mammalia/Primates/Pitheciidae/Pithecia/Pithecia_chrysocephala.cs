namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Pithecia;

/// <summary>
/// Species: Pithecia chrysocephala
/// NCBI TaxId: 2946515
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pithecia_chrysocephala : Pithecia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pithecia chrysocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pithecia_chrysocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2946515;
}
