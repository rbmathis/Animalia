using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Characodon;

/// <summary>
/// Abstract class for Characodon (genus).
/// NCBI TaxId: 208329
/// </summary>
public abstract class Characodon : Goodeidae, ICharacodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Characodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208329;

    /// <inheritdoc />
    public virtual string GenusName => "Characodon";

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
