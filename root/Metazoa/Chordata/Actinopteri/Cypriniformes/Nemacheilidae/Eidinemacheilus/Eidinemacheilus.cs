using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Eidinemacheilus;

/// <summary>
/// Abstract class for Eidinemacheilus (genus).
/// NCBI TaxId: 1905280
/// </summary>
public abstract class Eidinemacheilus : Nemacheilidae, IEidinemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eidinemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1905280;

    /// <inheritdoc />
    public virtual string GenusName => "Eidinemacheilus";

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
