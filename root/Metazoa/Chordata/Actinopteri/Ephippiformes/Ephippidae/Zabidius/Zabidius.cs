using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae.Zabidius;

/// <summary>
/// Abstract class for Zabidius (genus).
/// NCBI TaxId: 2609503
/// </summary>
public abstract class Zabidius : Ephippidae, IZabidius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zabidius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609503;

    /// <inheritdoc />
    public virtual string GenusName => "Zabidius";

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
