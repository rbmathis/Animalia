namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Diomedea;

/// <summary>
/// Species: Diomedea gibsoni
/// NCBI TaxId: 79625
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Diomedea_gibsoni : Diomedea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Diomedea gibsoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Diomedea_gibsoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79625;
}
