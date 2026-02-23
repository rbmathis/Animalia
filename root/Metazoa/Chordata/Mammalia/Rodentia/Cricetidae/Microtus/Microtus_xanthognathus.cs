namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus xanthognathus
/// NCBI TaxId: 10054
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_xanthognathus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus xanthognathus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_xanthognathus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10054;
}
