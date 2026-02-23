using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Bolinichthys;

/// <summary>
/// Abstract class for Bolinichthys (genus).
/// NCBI TaxId: 123244
/// </summary>
public abstract class Bolinichthys : Myctophidae, IBolinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bolinichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123244;

    /// <inheritdoc />
    public virtual string GenusName => "Bolinichthys";

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
