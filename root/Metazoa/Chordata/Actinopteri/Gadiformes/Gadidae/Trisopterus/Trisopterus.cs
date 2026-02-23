using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Trisopterus;

/// <summary>
/// Abstract class for Trisopterus (genus).
/// NCBI TaxId: 27721
/// </summary>
public abstract class Trisopterus : Gadidae, ITrisopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trisopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27721;

    /// <inheritdoc />
    public virtual string GenusName => "Trisopterus";

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
