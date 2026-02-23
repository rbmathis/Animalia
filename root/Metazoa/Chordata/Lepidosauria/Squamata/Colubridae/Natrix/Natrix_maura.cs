namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Natrix;

/// <summary>
/// Species: Natrix maura
/// NCBI TaxId: 8585
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Natrix_maura : Natrix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Natrix maura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Natrix_maura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8585;
}
