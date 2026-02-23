using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Rhodeus;

/// <summary>
/// Abstract class for Rhodeus (genus).
/// NCBI TaxId: 58326
/// </summary>
public abstract class Rhodeus : Acheilognathidae, IRhodeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58326;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodeus";

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
