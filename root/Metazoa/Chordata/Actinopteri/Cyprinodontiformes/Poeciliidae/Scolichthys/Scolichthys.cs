using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Scolichthys;

/// <summary>
/// Abstract class for Scolichthys (genus).
/// NCBI TaxId: 417469
/// </summary>
public abstract class Scolichthys : Poeciliidae, IScolichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scolichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 417469;

    /// <inheritdoc />
    public virtual string GenusName => "Scolichthys";

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
