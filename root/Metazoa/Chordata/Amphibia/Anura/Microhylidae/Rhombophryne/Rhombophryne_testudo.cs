namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Rhombophryne;

/// <summary>
/// Species: Rhombophryne testudo
/// NCBI TaxId: 289205
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhombophryne_testudo : Rhombophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhombophryne testudo";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhombophryne_testudo";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 289205;
}
