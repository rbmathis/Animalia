namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Crocodylus;

/// <summary>
/// Species: Crocodylus acutus x Crocodylus moreletii
/// NCBI TaxId: 3151661
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocodylus_acutus_x_Crocodylus_moreletii : Crocodylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocodylus acutus x Crocodylus moreletii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocodylus_acutus_x_Crocodylus_moreletii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3151661;
}
