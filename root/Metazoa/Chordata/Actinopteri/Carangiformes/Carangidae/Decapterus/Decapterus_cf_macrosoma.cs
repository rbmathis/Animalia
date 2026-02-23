namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Decapterus;

/// <summary>
/// Species: Decapterus cf. macrosoma
/// NCBI TaxId: 3049942
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Decapterus_cf_macrosoma : Decapterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Decapterus cf. macrosoma";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Decapterus_cf_macrosoma";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3049942;
}
