namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Leontocebus;

/// <summary>
/// Species: Leontocebus nigricollis
/// NCBI TaxId: 9489
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leontocebus_nigricollis : Leontocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leontocebus nigricollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leontocebus_nigricollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9489;
}
