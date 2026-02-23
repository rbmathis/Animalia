namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Harpesaurus;

/// <summary>
/// Species: Harpesaurus ensicauda
/// NCBI TaxId: 2670373
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Harpesaurus_ensicauda : Harpesaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Harpesaurus ensicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Harpesaurus_ensicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2670373;
}
