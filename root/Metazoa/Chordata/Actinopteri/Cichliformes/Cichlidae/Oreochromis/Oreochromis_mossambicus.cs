namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oreochromis;

/// <summary>
/// Species: Oreochromis mossambicus
/// NCBI TaxId: 8127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreochromis_mossambicus : Oreochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreochromis mossambicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreochromis_mossambicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8127;
}
