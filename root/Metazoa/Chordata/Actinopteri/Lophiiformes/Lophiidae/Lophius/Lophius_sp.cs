namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophius;

/// <summary>
/// Species: Lophius sp.
/// NCBI TaxId: 30791
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophius_sp : Lophius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30791;
}
