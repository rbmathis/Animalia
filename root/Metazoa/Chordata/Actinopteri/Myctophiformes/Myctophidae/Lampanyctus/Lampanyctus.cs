using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lampanyctus;

/// <summary>
/// Abstract class for Lampanyctus (genus).
/// NCBI TaxId: 71159
/// </summary>
public abstract class Lampanyctus : Myctophidae, ILampanyctus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lampanyctus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71159;

    /// <inheritdoc />
    public virtual string GenusName => "Lampanyctus";

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
