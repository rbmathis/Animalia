using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Valenciennellus;

/// <summary>
/// Abstract class for Valenciennellus (genus).
/// NCBI TaxId: 882894
/// </summary>
public abstract class Valenciennellus : Sternoptychidae, IValenciennellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Valenciennellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882894;

    /// <inheritdoc />
    public virtual string GenusName => "Valenciennellus";

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
