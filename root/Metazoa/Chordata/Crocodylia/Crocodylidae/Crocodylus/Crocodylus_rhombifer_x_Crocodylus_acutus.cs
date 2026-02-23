namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Crocodylus;

/// <summary>
/// Species: Crocodylus rhombifer x Crocodylus acutus
/// NCBI TaxId: 458528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocodylus_rhombifer_x_Crocodylus_acutus : Crocodylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocodylus rhombifer x Crocodylus acutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocodylus_rhombifer_x_Crocodylus_acutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 458528;
}
