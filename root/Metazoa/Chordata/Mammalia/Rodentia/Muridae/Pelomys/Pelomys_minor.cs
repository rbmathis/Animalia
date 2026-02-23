namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pelomys;

/// <summary>
/// Species: Pelomys minor
/// NCBI TaxId: 3148835
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelomys_minor : Pelomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelomys minor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelomys_minor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148835;
}
