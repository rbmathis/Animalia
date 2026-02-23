using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Spinibarbichthys;

/// <summary>
/// Abstract class for Spinibarbichthys (genus).
/// NCBI TaxId: 221415
/// </summary>
public abstract class Spinibarbichthys : Cyprinidae, ISpinibarbichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spinibarbichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221415;

    /// <inheritdoc />
    public virtual string GenusName => "Spinibarbichthys";

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
