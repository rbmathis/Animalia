using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbus;

/// <summary>
/// Abstract class for Barbus (genus).
/// NCBI TaxId: 40829
/// </summary>
public abstract class Barbus : Cyprinidae, IBarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40829;

    /// <inheritdoc />
    public virtual string GenusName => "Barbus";

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
