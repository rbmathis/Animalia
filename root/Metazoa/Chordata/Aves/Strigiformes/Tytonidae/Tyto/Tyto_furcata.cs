namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae.Tyto;

/// <summary>
/// Species: Tyto furcata
/// NCBI TaxId: 507989
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyto_furcata : Tyto
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyto furcata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyto_furcata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 507989;
}
