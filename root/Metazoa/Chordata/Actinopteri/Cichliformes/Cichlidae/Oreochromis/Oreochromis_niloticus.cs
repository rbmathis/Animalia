namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oreochromis;

/// <summary>
/// Species: Oreochromis niloticus
/// NCBI TaxId: 8128
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreochromis_niloticus : Oreochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreochromis niloticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreochromis_niloticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8128;
}
