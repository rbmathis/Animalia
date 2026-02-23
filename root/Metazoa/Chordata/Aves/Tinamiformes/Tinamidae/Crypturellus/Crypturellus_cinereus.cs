namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Crypturellus;

/// <summary>
/// Species: Crypturellus cinereus
/// NCBI TaxId: 1118537
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crypturellus_cinereus : Crypturellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crypturellus cinereus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crypturellus_cinereus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1118537;
}
