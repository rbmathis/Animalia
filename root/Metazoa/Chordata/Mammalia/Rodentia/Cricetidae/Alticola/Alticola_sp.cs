namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Alticola;

/// <summary>
/// Species: Alticola sp.
/// NCBI TaxId: 3464307
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alticola_sp : Alticola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alticola sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alticola_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3464307;
}
