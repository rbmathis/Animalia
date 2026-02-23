using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Thysanichthys;

/// <summary>
/// Abstract class for Thysanichthys (genus).
/// NCBI TaxId: 274710
/// </summary>
public abstract class Thysanichthys : Scorpaenidae, IThysanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thysanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274710;

    /// <inheritdoc />
    public virtual string GenusName => "Thysanichthys";

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
