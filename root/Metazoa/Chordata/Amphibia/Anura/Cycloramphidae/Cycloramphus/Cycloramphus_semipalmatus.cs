namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae.Cycloramphus;

/// <summary>
/// Species: Cycloramphus semipalmatus
/// NCBI TaxId: 2601830
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cycloramphus_semipalmatus : Cycloramphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cycloramphus semipalmatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cycloramphus_semipalmatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2601830;
}
