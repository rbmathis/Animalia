using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Orestias;

/// <summary>
/// Abstract class for Orestias (genus).
/// NCBI TaxId: 30747
/// </summary>
public abstract class Orestias : Cyprinodontidae, IOrestias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orestias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30747;

    /// <inheritdoc />
    public virtual string GenusName => "Orestias";

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
