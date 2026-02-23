using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Horadandia;

/// <summary>
/// Abstract class for Horadandia (genus).
/// NCBI TaxId: 432410
/// </summary>
public abstract class Horadandia : Danionidae, IHoradandia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Horadandia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432410;

    /// <inheritdoc />
    public virtual string GenusName => "Horadandia";

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
