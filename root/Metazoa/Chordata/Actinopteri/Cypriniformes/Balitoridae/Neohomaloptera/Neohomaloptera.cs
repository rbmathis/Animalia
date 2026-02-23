using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Neohomaloptera;

/// <summary>
/// Abstract class for Neohomaloptera (genus).
/// NCBI TaxId: 1001940
/// </summary>
public abstract class Neohomaloptera : Balitoridae, INeohomaloptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neohomaloptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1001940;

    /// <inheritdoc />
    public virtual string GenusName => "Neohomaloptera";

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
