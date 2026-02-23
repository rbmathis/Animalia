namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Handleyomys;

/// <summary>
/// Species: Handleyomys rostratus
/// NCBI TaxId: 530172
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Handleyomys_rostratus : Handleyomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Handleyomys rostratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Handleyomys_rostratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 530172;
}
