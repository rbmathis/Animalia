namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Otomys;

/// <summary>
/// Species: Otomys sp. Mount Kenya
/// NCBI TaxId: 2781603
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otomys_sp_Mount_Kenya : Otomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otomys sp. Mount Kenya";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otomys_sp_Mount_Kenya";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2781603;
}
