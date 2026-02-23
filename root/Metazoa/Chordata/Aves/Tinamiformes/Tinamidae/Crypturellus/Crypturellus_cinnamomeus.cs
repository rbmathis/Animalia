namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Crypturellus;

/// <summary>
/// Species: Crypturellus cinnamomeus
/// NCBI TaxId: 889801
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crypturellus_cinnamomeus : Crypturellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crypturellus cinnamomeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crypturellus_cinnamomeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 889801;
}
