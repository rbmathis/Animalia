namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Icterus;

/// <summary>
/// Species: Icterus auricapillus
/// NCBI TaxId: 105597
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Icterus_auricapillus : Icterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Icterus auricapillus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Icterus_auricapillus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 105597;
}
