namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichla;

/// <summary>
/// Species: Cichla sp. 'Azul'
/// NCBI TaxId: 303888
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cichla_sp_Azul : Cichla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cichla sp. 'Azul'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cichla_sp_Azul";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 303888;
}
