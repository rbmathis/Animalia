namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Acridotheres;

/// <summary>
/// Species: Acridotheres tristis
/// NCBI TaxId: 279927
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acridotheres_tristis : Acridotheres
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acridotheres tristis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acridotheres_tristis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279927;
}
