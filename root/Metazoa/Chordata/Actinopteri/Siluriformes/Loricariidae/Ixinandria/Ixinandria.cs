using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Ixinandria;

/// <summary>
/// Abstract class for Ixinandria (genus).
/// NCBI TaxId: 510788
/// </summary>
public abstract class Ixinandria : Loricariidae, IIxinandria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ixinandria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510788;

    /// <inheritdoc />
    public virtual string GenusName => "Ixinandria";

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
