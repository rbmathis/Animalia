namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichla;

/// <summary>
/// Species: Cichla sp. Xingu
/// NCBI TaxId: 400232
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cichla_sp_Xingu : Cichla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cichla sp. Xingu";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cichla_sp_Xingu";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 400232;
}
