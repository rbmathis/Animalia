using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Micronemacheilus;

/// <summary>
/// Abstract class for Micronemacheilus (genus).
/// NCBI TaxId: 192017
/// </summary>
public abstract class Micronemacheilus : Nemacheilidae, IMicronemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micronemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192017;

    /// <inheritdoc />
    public virtual string GenusName => "Micronemacheilus";

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
