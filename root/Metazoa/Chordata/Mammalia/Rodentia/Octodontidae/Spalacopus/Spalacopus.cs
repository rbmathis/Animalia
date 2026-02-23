using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Spalacopus;

/// <summary>
/// Abstract class for Spalacopus (genus).
/// NCBI TaxId: 61879
/// </summary>
public abstract class Spalacopus : Octodontidae, ISpalacopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spalacopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61879;

    /// <inheritdoc />
    public virtual string GenusName => "Spalacopus";

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
