using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae.Typhlomys;

/// <summary>
/// Abstract class for Typhlomys (genus).
/// NCBI TaxId: 687454
/// </summary>
public abstract class Typhlomys : Platacanthomyidae, ITyphlomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 687454;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlomys";

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
