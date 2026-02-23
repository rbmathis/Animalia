using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Clypeobarbus;

/// <summary>
/// Abstract class for Clypeobarbus (genus).
/// NCBI TaxId: 643460
/// </summary>
public abstract class Clypeobarbus : Cyprinidae, IClypeobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clypeobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643460;

    /// <inheritdoc />
    public virtual string GenusName => "Clypeobarbus";

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
