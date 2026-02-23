namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Species: Passer flaveolus
/// NCBI TaxId: 150915
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Passer_flaveolus : Passer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Passer flaveolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Passer_flaveolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150915;
}
