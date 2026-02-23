namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus hemionus
/// NCBI TaxId: 9794
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_hemionus : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus hemionus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_hemionus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9794;
}
