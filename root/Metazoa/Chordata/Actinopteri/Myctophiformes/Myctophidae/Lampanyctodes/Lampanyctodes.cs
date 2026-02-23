using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lampanyctodes;

/// <summary>
/// Abstract class for Lampanyctodes (genus).
/// NCBI TaxId: 123254
/// </summary>
public abstract class Lampanyctodes : Myctophidae, ILampanyctodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lampanyctodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123254;

    /// <inheritdoc />
    public virtual string GenusName => "Lampanyctodes";

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
