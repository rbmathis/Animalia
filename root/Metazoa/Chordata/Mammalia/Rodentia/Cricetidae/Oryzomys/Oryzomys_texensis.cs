namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oryzomys;

/// <summary>
/// Species: Oryzomys texensis
/// NCBI TaxId: 478565
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryzomys_texensis : Oryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryzomys texensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryzomys_texensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 478565;
}
