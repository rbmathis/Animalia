namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Platysaurus;

/// <summary>
/// Species: Platysaurus orientalis
/// NCBI TaxId: 1699656
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platysaurus_orientalis : Platysaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platysaurus orientalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platysaurus_orientalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1699656;
}
