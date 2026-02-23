namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Phrynosoma;

/// <summary>
/// Species: Phrynosoma modestum
/// NCBI TaxId: 43612
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynosoma_modestum : Phrynosoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynosoma modestum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynosoma_modestum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43612;
}
