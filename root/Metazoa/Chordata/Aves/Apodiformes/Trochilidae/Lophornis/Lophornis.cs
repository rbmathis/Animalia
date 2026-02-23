using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Lophornis;

/// <summary>
/// Abstract class for Lophornis (genus).
/// NCBI TaxId: 304656
/// </summary>
public abstract class Lophornis : Trochilidae, ILophornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304656;

    /// <inheritdoc />
    public virtual string GenusName => "Lophornis";

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
