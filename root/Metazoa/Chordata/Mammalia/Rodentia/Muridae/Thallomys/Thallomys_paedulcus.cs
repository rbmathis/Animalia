namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thallomys;

/// <summary>
/// Species: Thallomys paedulcus
/// NCBI TaxId: 332673
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thallomys_paedulcus : Thallomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thallomys paedulcus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thallomys_paedulcus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 332673;
}
