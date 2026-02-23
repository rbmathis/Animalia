using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Mastigopterus;

/// <summary>
/// Abstract class for Mastigopterus (genus).
/// NCBI TaxId: 2768301
/// </summary>
public abstract class Mastigopterus : Ophidiidae, IMastigopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mastigopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768301;

    /// <inheritdoc />
    public virtual string GenusName => "Mastigopterus";

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
