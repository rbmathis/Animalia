using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Gonichthys;

/// <summary>
/// Abstract class for Gonichthys (genus).
/// NCBI TaxId: 123343
/// </summary>
public abstract class Gonichthys : Myctophidae, IGonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123343;

    /// <inheritdoc />
    public virtual string GenusName => "Gonichthys";

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
