namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Monodelphis;

/// <summary>
/// Species: Monodelphis palliolata
/// NCBI TaxId: 1523450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monodelphis_palliolata : Monodelphis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monodelphis palliolata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monodelphis_palliolata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1523450;
}
