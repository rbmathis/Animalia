using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cansumys;

/// <summary>
/// Abstract class for Cansumys (genus).
/// NCBI TaxId: 1343852
/// </summary>
public abstract class Cansumys : Cricetidae, ICansumys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cansumys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1343852;

    /// <inheritdoc />
    public virtual string GenusName => "Cansumys";

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
