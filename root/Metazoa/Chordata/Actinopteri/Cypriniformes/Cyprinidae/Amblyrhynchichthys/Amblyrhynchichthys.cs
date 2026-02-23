using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Amblyrhynchichthys;

/// <summary>
/// Abstract class for Amblyrhynchichthys (genus).
/// NCBI TaxId: 643416
/// </summary>
public abstract class Amblyrhynchichthys : Cyprinidae, IAmblyrhynchichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyrhynchichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643416;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyrhynchichthys";

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
