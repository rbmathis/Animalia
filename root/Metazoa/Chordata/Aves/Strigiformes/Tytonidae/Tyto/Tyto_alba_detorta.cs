namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae.Tyto;

/// <summary>
/// Species: Tyto alba detorta
/// NCBI TaxId: 2338547
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tyto_alba_detorta : Tyto
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tyto alba detorta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tyto_alba_detorta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2338547;
}
