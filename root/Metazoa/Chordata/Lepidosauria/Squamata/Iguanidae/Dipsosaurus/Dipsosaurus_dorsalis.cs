namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Dipsosaurus;

/// <summary>
/// Species: Dipsosaurus dorsalis
/// NCBI TaxId: 51217
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dipsosaurus_dorsalis : Dipsosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dipsosaurus dorsalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dipsosaurus_dorsalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51217;
}
