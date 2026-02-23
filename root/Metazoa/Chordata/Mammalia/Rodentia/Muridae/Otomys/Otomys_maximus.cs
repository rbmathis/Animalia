namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Otomys;

/// <summary>
/// Species: Otomys maximus
/// NCBI TaxId: 190450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otomys_maximus : Otomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otomys maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otomys_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 190450;
}
