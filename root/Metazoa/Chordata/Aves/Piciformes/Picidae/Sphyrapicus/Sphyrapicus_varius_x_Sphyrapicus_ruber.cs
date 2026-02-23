namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Sphyrapicus;

/// <summary>
/// Species: Sphyrapicus varius x Sphyrapicus ruber
/// NCBI TaxId: 3452689
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphyrapicus_varius_x_Sphyrapicus_ruber : Sphyrapicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphyrapicus varius x Sphyrapicus ruber";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphyrapicus_varius_x_Sphyrapicus_ruber";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3452689;
}
