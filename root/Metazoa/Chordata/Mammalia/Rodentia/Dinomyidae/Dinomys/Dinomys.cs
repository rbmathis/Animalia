using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dinomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dinomyidae.Dinomys;

/// <summary>
/// Abstract class for Dinomys (genus).
/// NCBI TaxId: 108857
/// </summary>
public abstract class Dinomys : Dinomyidae, IDinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108857;

    /// <inheritdoc />
    public virtual string GenusName => "Dinomys";

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
