namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Phrynosoma;

/// <summary>
/// Species: Phrynosoma sp.
/// NCBI TaxId: 2878398
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynosoma_sp : Phrynosoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynosoma sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynosoma_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2878398;
}
