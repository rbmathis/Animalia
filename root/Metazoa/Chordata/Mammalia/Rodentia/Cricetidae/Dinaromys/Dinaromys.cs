using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Dinaromys;

/// <summary>
/// Abstract class for Dinaromys (genus).
/// NCBI TaxId: 418654
/// </summary>
public abstract class Dinaromys : Cricetidae, IDinaromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinaromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 418654;

    /// <inheritdoc />
    public virtual string GenusName => "Dinaromys";

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
