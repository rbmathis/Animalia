using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae.Octodontomys;

/// <summary>
/// Abstract class for Octodontomys (genus).
/// NCBI TaxId: 170739
/// </summary>
public abstract class Octodontomys : Ctenomyidae, IOctodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Octodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170739;

    /// <inheritdoc />
    public virtual string GenusName => "Octodontomys";

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
