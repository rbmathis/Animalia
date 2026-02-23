namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sousa;

/// <summary>
/// Species: Sousa plumbea
/// NCBI TaxId: 2880878
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sousa_plumbea : Sousa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sousa plumbea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sousa_plumbea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2880878;
}
