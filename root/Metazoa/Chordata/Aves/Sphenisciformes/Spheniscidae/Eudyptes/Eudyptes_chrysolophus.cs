namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Eudyptes;

/// <summary>
/// Species: Eudyptes chrysolophus
/// NCBI TaxId: 79627
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eudyptes_chrysolophus : Eudyptes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eudyptes chrysolophus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eudyptes_chrysolophus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79627;
}
