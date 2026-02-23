using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Homostolus;

/// <summary>
/// Abstract class for Homostolus (genus).
/// NCBI TaxId: 1812879
/// </summary>
public abstract class Homostolus : Ophidiidae, IHomostolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homostolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1812879;

    /// <inheritdoc />
    public virtual string GenusName => "Homostolus";

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
