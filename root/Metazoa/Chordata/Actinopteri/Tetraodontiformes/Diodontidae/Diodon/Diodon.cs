using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Diodon;

/// <summary>
/// Abstract class for Diodon (genus).
/// NCBI TaxId: 223142
/// </summary>
public abstract class Diodon : Diodontidae, IDiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223142;

    /// <inheritdoc />
    public virtual string GenusName => "Diodon";

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
