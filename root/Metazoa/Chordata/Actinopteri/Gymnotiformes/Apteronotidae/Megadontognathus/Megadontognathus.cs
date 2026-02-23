using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Megadontognathus;

/// <summary>
/// Abstract class for Megadontognathus (genus).
/// NCBI TaxId: 2507213
/// </summary>
public abstract class Megadontognathus : Apteronotidae, IMegadontognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megadontognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2507213;

    /// <inheritdoc />
    public virtual string GenusName => "Megadontognathus";

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
