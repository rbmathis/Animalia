namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Otomys;

/// <summary>
/// Species: Otomys cf. cheesmani DM-2023
/// NCBI TaxId: 3046426
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otomys_cf_cheesmani_DM_2023 : Otomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otomys cf. cheesmani DM-2023";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otomys_cf_cheesmani_DM_2023";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3046426;
}
