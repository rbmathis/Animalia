using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Spinibarbus;

/// <summary>
/// Abstract class for Spinibarbus (genus).
/// NCBI TaxId: 75368
/// </summary>
public abstract class Spinibarbus : Cyprinidae, ISpinibarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spinibarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75368;

    /// <inheritdoc />
    public virtual string GenusName => "Spinibarbus";

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
