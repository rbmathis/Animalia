using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae.Platacanthomys;

/// <summary>
/// Abstract class for Platacanthomys (genus).
/// NCBI TaxId: 2502161
/// </summary>
public abstract class Platacanthomys : Platacanthomyidae, IPlatacanthomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platacanthomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2502161;

    /// <inheritdoc />
    public virtual string GenusName => "Platacanthomys";

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
