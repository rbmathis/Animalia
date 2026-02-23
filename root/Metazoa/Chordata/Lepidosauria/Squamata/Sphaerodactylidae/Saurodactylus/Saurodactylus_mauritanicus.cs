namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Saurodactylus;

/// <summary>
/// Species: Saurodactylus mauritanicus
/// NCBI TaxId: 456485
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saurodactylus_mauritanicus : Saurodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saurodactylus mauritanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saurodactylus_mauritanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 456485;
}
