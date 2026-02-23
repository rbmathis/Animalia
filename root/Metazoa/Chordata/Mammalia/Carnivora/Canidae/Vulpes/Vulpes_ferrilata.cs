namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Vulpes;

/// <summary>
/// Species: Vulpes ferrilata
/// NCBI TaxId: 561074
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vulpes_ferrilata : Vulpes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vulpes ferrilata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vulpes_ferrilata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 561074;
}
