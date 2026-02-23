namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Bradypodidae.Bradypus;

/// <summary>
/// Species: Bradypus tridactylus
/// NCBI TaxId: 9354
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bradypus_tridactylus : Bradypus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bradypus tridactylus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bradypus_tridactylus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9354;
}
