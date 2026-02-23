using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Wattsia;

/// <summary>
/// Abstract class for Wattsia (genus).
/// NCBI TaxId: 182663
/// </summary>
public abstract class Wattsia : Lethrinidae, IWattsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wattsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182663;

    /// <inheritdoc />
    public virtual string GenusName => "Wattsia";

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
