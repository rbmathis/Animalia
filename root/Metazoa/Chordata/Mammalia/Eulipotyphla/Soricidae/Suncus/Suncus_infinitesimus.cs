namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus;

/// <summary>
/// Species: Suncus infinitesimus
/// NCBI TaxId: 148981
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Suncus_infinitesimus : Suncus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Suncus infinitesimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Suncus_infinitesimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 148981;
}
