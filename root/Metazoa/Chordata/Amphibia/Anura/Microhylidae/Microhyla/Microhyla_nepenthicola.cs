namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Species: Microhyla nepenthicola
/// NCBI TaxId: 705555
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microhyla_nepenthicola : Microhyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microhyla nepenthicola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microhyla_nepenthicola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 705555;
}
