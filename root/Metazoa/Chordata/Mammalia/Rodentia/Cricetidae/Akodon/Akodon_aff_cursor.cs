namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Akodon;

/// <summary>
/// Species: Akodon aff. cursor
/// NCBI TaxId: 106109
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Akodon_aff_cursor : Akodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Akodon aff. cursor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Akodon_aff_cursor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 106109;
}
