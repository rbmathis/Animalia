namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Urosaurus;

/// <summary>
/// Species: Urosaurus bicarinatus
/// NCBI TaxId: 110859
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Urosaurus_bicarinatus : Urosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Urosaurus bicarinatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Urosaurus_bicarinatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 110859;
}
