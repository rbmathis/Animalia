namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Cheirogaleus;

/// <summary>
/// Species: Cheirogaleus medius
/// NCBI TaxId: 9460
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cheirogaleus_medius : Cheirogaleus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cheirogaleus medius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cheirogaleus_medius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9460;
}
