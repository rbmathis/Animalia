namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Struthionidae.Struthio;

/// <summary>
/// Species: Struthio camelus x Struthio molybdophanes
/// NCBI TaxId: 3239430
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Struthio_camelus_x_Struthio_molybdophanes : Struthio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Struthio camelus x Struthio molybdophanes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Struthio_camelus_x_Struthio_molybdophanes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3239430;
}
