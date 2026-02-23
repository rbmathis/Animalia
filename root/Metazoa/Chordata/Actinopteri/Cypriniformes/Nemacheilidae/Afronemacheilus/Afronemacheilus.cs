using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Afronemacheilus;

/// <summary>
/// Abstract class for Afronemacheilus (genus).
/// NCBI TaxId: 2964545
/// </summary>
public abstract class Afronemacheilus : Nemacheilidae, IAfronemacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afronemacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2964545;

    /// <inheritdoc />
    public virtual string GenusName => "Afronemacheilus";

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
