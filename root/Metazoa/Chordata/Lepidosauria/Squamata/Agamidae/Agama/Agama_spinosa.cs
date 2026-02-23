namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Species: Agama spinosa
/// NCBI TaxId: 175472
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agama_spinosa : Agama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agama spinosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agama_spinosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175472;
}
