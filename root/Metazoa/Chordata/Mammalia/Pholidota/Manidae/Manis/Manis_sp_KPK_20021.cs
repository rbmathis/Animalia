namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Manis;

/// <summary>
/// Species: Manis sp. KPK-2002.1
/// NCBI TaxId: 213499
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manis_sp_KPK_20021 : Manis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manis sp. KPK-2002.1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manis_sp_KPK_20021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 213499;
}
