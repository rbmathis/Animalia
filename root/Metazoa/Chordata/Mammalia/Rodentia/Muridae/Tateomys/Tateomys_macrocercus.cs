namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tateomys;

/// <summary>
/// Species: Tateomys macrocercus
/// NCBI TaxId: 1795474
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tateomys_macrocercus : Tateomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tateomys macrocercus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tateomys_macrocercus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1795474;
}
