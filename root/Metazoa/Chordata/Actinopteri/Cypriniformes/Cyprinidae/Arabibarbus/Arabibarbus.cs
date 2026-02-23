using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Arabibarbus;

/// <summary>
/// Abstract class for Arabibarbus (genus).
/// NCBI TaxId: 1541198
/// </summary>
public abstract class Arabibarbus : Cyprinidae, IArabibarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arabibarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1541198;

    /// <inheritdoc />
    public virtual string GenusName => "Arabibarbus";

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
