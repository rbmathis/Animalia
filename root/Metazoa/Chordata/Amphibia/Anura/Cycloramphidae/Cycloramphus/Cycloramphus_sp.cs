namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae.Cycloramphus;

/// <summary>
/// Species: Cycloramphus sp.
/// NCBI TaxId: 3374871
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cycloramphus_sp : Cycloramphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cycloramphus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cycloramphus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3374871;
}
