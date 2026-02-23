using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Mesonoemacheilus;

/// <summary>
/// Abstract class for Mesonoemacheilus (genus).
/// NCBI TaxId: 425515
/// </summary>
public abstract class Mesonoemacheilus : Nemacheilidae, IMesonoemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesonoemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425515;

    /// <inheritdoc />
    public virtual string GenusName => "Mesonoemacheilus";

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
