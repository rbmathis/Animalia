using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Neochanna;

/// <summary>
/// Abstract class for Neochanna (genus).
/// NCBI TaxId: 66450
/// </summary>
public abstract class Neochanna : Galaxiidae, INeochanna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neochanna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66450;

    /// <inheritdoc />
    public virtual string GenusName => "Neochanna";

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
