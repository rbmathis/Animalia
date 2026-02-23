namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Osteoglossum;

/// <summary>
/// Species: Osteoglossum sp.
/// NCBI TaxId: 27725
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteoglossum_sp : Osteoglossum
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteoglossum sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteoglossum_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27725;
}
