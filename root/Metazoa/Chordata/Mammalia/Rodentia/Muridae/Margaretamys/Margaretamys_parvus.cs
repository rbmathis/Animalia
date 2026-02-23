namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Margaretamys;

/// <summary>
/// Species: Margaretamys parvus
/// NCBI TaxId: 2716770
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Margaretamys_parvus : Margaretamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Margaretamys parvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Margaretamys_parvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2716770;
}
