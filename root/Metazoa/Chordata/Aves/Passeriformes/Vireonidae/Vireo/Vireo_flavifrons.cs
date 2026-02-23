namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireo;

/// <summary>
/// Species: Vireo flavifrons
/// NCBI TaxId: 81621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vireo_flavifrons : Vireo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vireo flavifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vireo_flavifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 81621;
}
