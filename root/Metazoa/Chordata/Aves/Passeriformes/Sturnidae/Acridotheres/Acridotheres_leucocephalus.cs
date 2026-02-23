namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Acridotheres;

/// <summary>
/// Species: Acridotheres leucocephalus
/// NCBI TaxId: 3149182
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acridotheres_leucocephalus : Acridotheres
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acridotheres leucocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acridotheres_leucocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3149182;
}
