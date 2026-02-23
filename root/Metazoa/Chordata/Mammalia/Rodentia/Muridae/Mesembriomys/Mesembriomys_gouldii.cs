namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mesembriomys;

/// <summary>
/// Species: Mesembriomys gouldii
/// NCBI TaxId: 337228
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesembriomys_gouldii : Mesembriomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesembriomys gouldii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesembriomys_gouldii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 337228;
}
