using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Probarbus;

/// <summary>
/// Abstract class for Probarbus (genus).
/// NCBI TaxId: 266795
/// </summary>
public abstract class Probarbus : Cyprinidae, IProbarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Probarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266795;

    /// <inheritdoc />
    public virtual string GenusName => "Probarbus";

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
