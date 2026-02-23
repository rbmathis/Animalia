namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Antilocapridae.Antilocapra;

/// <summary>
/// Species: Antilocapra americana
/// NCBI TaxId: 9891
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Antilocapra_americana : Antilocapra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Antilocapra americana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Antilocapra_americana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9891;
}
