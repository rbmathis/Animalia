namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Poecile;

/// <summary>
/// Species: Poecile weigoldicus
/// NCBI TaxId: 1069444
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Poecile_weigoldicus : Poecile
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Poecile weigoldicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Poecile_weigoldicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1069444;
}
