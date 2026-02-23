namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichla;

/// <summary>
/// Species: Cichla sp.
/// NCBI TaxId: 40173
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cichla_sp : Cichla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cichla sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cichla_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 40173;
}
