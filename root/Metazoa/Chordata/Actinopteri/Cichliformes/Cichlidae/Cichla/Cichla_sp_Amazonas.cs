namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichla;

/// <summary>
/// Species: Cichla sp. Amazonas
/// NCBI TaxId: 400233
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cichla_sp_Amazonas : Cichla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cichla sp. Amazonas";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cichla_sp_Amazonas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 400233;
}
