namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Thinornis;

/// <summary>
/// Species: Thinornis novaeseelandiae
/// NCBI TaxId: 425654
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thinornis_novaeseelandiae : Thinornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thinornis novaeseelandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thinornis_novaeseelandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 425654;
}
