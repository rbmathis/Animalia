namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Numenius;

/// <summary>
/// Species: Numenius madagascariensis
/// NCBI TaxId: 171268
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Numenius_madagascariensis : Numenius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Numenius madagascariensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Numenius_madagascariensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171268;
}
