using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Loweina;

/// <summary>
/// Abstract class for Loweina (genus).
/// NCBI TaxId: 123345
/// </summary>
public abstract class Loweina : Myctophidae, ILoweina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loweina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123345;

    /// <inheritdoc />
    public virtual string GenusName => "Loweina";

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
