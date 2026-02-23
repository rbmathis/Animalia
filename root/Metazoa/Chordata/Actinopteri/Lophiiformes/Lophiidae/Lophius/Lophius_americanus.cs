namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophius;

/// <summary>
/// Species: Lophius americanus
/// NCBI TaxId: 8073
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophius_americanus : Lophius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophius americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophius_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8073;
}
