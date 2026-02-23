namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Kobus;

/// <summary>
/// Species: Kobus vardonii
/// NCBI TaxId: 59533
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kobus_vardonii : Kobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kobus vardonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kobus_vardonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59533;
}
