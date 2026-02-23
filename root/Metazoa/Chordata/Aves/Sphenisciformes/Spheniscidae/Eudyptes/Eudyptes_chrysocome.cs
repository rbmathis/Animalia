namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Eudyptes;

/// <summary>
/// Species: Eudyptes chrysocome
/// NCBI TaxId: 79626
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eudyptes_chrysocome : Eudyptes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eudyptes chrysocome";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eudyptes_chrysocome";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79626;
}
