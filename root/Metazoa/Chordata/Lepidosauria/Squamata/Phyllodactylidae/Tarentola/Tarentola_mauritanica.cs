namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Tarentola;

/// <summary>
/// Species: Tarentola mauritanica
/// NCBI TaxId: 8569
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tarentola_mauritanica : Tarentola
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tarentola mauritanica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tarentola_mauritanica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8569;
}
