namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclidae.Cinclus;

/// <summary>
/// Species: Cinclus leucocephalus
/// NCBI TaxId: 1740308
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cinclus_leucocephalus : Cinclus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cinclus leucocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cinclus_leucocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1740308;
}
