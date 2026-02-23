using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Richardsonichthys;

/// <summary>
/// Abstract class for Richardsonichthys (genus).
/// NCBI TaxId: 1604636
/// </summary>
public abstract class Richardsonichthys : Tetrarogidae, IRichardsonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Richardsonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604636;

    /// <inheritdoc />
    public virtual string GenusName => "Richardsonichthys";

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
