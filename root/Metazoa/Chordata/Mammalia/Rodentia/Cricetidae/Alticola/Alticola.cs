using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Alticola;

/// <summary>
/// Abstract class for Alticola (genus).
/// NCBI TaxId: 98315
/// </summary>
public abstract class Alticola : Cricetidae, IAlticola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alticola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98315;

    /// <inheritdoc />
    public virtual string GenusName => "Alticola";

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
