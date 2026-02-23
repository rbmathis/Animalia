namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Stenella;

/// <summary>
/// Species: Stenella longirostris
/// NCBI TaxId: 9736
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stenella_longirostris : Stenella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stenella longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stenella_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9736;
}
