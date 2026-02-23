namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Colaptes;

/// <summary>
/// Species: Colaptes rubiginosus
/// NCBI TaxId: 51361
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colaptes_rubiginosus : Colaptes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colaptes rubiginosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colaptes_rubiginosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51361;
}
