using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Hemibarbus;

/// <summary>
/// Abstract class for Hemibarbus (genus).
/// NCBI TaxId: 80792
/// </summary>
public abstract class Hemibarbus : Gobionidae, IHemibarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemibarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80792;

    /// <inheritdoc />
    public virtual string GenusName => "Hemibarbus";

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
