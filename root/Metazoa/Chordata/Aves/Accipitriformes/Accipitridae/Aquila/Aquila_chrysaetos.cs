namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Aquila;

/// <summary>
/// Species: Aquila chrysaetos
/// NCBI TaxId: 8962
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aquila_chrysaetos : Aquila
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aquila chrysaetos";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aquila_chrysaetos";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8962;
}
