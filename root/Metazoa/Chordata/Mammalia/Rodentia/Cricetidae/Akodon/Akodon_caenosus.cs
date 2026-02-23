namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Akodon;

/// <summary>
/// Species: Akodon caenosus
/// NCBI TaxId: 865619
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Akodon_caenosus : Akodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Akodon caenosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Akodon_caenosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 865619;
}
