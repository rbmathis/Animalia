using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Claea;

/// <summary>
/// Abstract class for Claea (genus).
/// NCBI TaxId: 1173619
/// </summary>
public abstract class Claea : Nemacheilidae, IClaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Claea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1173619;

    /// <inheritdoc />
    public virtual string GenusName => "Claea";

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
