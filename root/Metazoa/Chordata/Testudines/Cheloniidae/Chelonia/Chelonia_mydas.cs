namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Chelonia;

/// <summary>
/// Species: Chelonia mydas
/// NCBI TaxId: 8469
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelonia_mydas : Chelonia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelonia mydas";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelonia_mydas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8469;
}
