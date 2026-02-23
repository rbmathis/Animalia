using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Halcyon;

/// <summary>
/// Abstract class for Halcyon (genus).
/// NCBI TaxId: 170865
/// </summary>
public abstract class Halcyon : Alcedinidae, IHalcyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halcyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170865;

    /// <inheritdoc />
    public virtual string GenusName => "Halcyon";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
