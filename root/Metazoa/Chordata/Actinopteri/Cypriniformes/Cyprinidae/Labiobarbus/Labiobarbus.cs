using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labiobarbus;

/// <summary>
/// Abstract class for Labiobarbus (genus).
/// NCBI TaxId: 381597
/// </summary>
public abstract class Labiobarbus : Cyprinidae, ILabiobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labiobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381597;

    /// <inheritdoc />
    public virtual string GenusName => "Labiobarbus";

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
