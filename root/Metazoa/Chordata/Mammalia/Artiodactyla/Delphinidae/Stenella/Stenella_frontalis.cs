namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Stenella;

/// <summary>
/// Species: Stenella frontalis
/// NCBI TaxId: 103590
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stenella_frontalis : Stenella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stenella frontalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stenella_frontalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103590;
}
