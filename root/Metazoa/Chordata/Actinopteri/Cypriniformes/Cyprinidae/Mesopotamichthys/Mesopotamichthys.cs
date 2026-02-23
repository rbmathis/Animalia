using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Mesopotamichthys;

/// <summary>
/// Abstract class for Mesopotamichthys (genus).
/// NCBI TaxId: 1109708
/// </summary>
public abstract class Mesopotamichthys : Cyprinidae, IMesopotamichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesopotamichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1109708;

    /// <inheritdoc />
    public virtual string GenusName => "Mesopotamichthys";

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
