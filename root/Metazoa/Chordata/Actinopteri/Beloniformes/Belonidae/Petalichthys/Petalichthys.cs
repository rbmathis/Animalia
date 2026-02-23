using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Petalichthys;

/// <summary>
/// Abstract class for Petalichthys (genus).
/// NCBI TaxId: 293915
/// </summary>
public abstract class Petalichthys : Belonidae, IPetalichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petalichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 293915;

    /// <inheritdoc />
    public virtual string GenusName => "Petalichthys";

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
