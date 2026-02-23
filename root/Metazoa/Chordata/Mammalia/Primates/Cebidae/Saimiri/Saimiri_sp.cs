namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saimiri;

/// <summary>
/// Species: Saimiri sp.
/// NCBI TaxId: 1561164
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saimiri_sp : Saimiri
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saimiri sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saimiri_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1561164;
}
