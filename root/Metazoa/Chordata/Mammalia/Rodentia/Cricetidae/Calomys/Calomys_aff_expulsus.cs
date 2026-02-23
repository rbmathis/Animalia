namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

/// <summary>
/// Species: Calomys aff. expulsus
/// NCBI TaxId: 327559
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomys_aff_expulsus : Calomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomys aff. expulsus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomys_aff_expulsus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 327559;
}
