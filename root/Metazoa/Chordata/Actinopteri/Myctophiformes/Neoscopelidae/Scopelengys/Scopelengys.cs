using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae.Scopelengys;

/// <summary>
/// Abstract class for Scopelengys (genus).
/// NCBI TaxId: 123229
/// </summary>
public abstract class Scopelengys : Neoscopelidae, IScopelengys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scopelengys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123229;

    /// <inheritdoc />
    public virtual string GenusName => "Scopelengys";

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
