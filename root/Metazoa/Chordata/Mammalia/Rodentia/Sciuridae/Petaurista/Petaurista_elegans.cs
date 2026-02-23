namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petaurista;

/// <summary>
/// Species: Petaurista elegans
/// NCBI TaxId: 135717
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petaurista_elegans : Petaurista
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petaurista elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petaurista_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 135717;
}
