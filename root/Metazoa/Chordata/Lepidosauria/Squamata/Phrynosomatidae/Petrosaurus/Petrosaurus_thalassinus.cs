namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Petrosaurus;

/// <summary>
/// Species: Petrosaurus thalassinus
/// NCBI TaxId: 81826
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petrosaurus_thalassinus : Petrosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petrosaurus thalassinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petrosaurus_thalassinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 81826;
}
