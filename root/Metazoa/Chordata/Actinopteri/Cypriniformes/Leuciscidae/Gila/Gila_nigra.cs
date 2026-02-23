namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Gila;

/// <summary>
/// Species: Gila nigra
/// NCBI TaxId: 703242
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gila_nigra : Gila
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gila nigra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gila_nigra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 703242;
}
