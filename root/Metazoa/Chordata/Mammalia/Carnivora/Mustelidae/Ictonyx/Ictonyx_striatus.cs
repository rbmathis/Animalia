namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Ictonyx;

/// <summary>
/// Species: Ictonyx striatus
/// NCBI TaxId: 55050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ictonyx_striatus : Ictonyx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ictonyx striatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ictonyx_striatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55050;
}
