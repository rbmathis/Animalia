using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Oidiphorus;

/// <summary>
/// Abstract class for Oidiphorus (genus).
/// NCBI TaxId: 948064
/// </summary>
public abstract class Oidiphorus : Zoarcidae, IOidiphorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oidiphorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948064;

    /// <inheritdoc />
    public virtual string GenusName => "Oidiphorus";

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
