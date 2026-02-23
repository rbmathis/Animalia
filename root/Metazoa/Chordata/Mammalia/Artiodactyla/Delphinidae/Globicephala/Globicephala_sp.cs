namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Globicephala;

/// <summary>
/// Species: Globicephala sp.
/// NCBI TaxId: 77568
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Globicephala_sp : Globicephala
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Globicephala sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Globicephala_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 77568;
}
