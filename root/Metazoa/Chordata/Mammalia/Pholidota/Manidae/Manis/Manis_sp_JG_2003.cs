namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Manis;

/// <summary>
/// Species: Manis sp. JG-2003
/// NCBI TaxId: 227858
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manis_sp_JG_2003 : Manis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manis sp. JG-2003";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manis_sp_JG_2003";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227858;
}
