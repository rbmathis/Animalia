using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Girardinichthys;

/// <summary>
/// Abstract class for Girardinichthys (genus).
/// NCBI TaxId: 208332
/// </summary>
public abstract class Girardinichthys : Goodeidae, IGirardinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Girardinichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208332;

    /// <inheritdoc />
    public virtual string GenusName => "Girardinichthys";

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
