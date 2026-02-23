namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Charadrius;

/// <summary>
/// Species: Charadrius morinellus
/// NCBI TaxId: 211599
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Charadrius_morinellus : Charadrius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Charadrius morinellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Charadrius_morinellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 211599;
}
