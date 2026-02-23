namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Euroscaptor;

/// <summary>
/// Species: Euroscaptor sp. AB-2015
/// NCBI TaxId: 1748406
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euroscaptor_sp_AB_2015 : Euroscaptor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euroscaptor sp. AB-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euroscaptor_sp_AB_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1748406;
}
