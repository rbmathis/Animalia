namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Megachasmidae.Megachasma;

/// <summary>
/// Species: Megachasma pelagios
/// NCBI TaxId: 57985
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megachasma_pelagios : Megachasma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megachasma pelagios";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megachasma_pelagios";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57985;
}
