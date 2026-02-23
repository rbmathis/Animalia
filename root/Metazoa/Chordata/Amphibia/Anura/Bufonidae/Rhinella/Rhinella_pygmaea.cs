namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Species: Rhinella pygmaea
/// NCBI TaxId: 1079989
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinella_pygmaea : Rhinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinella pygmaea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinella_pygmaea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1079989;
}
