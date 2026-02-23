using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Arvicola;

/// <summary>
/// Abstract class for Arvicola (genus).
/// NCBI TaxId: 10049
/// </summary>
public abstract class Arvicola : Cricetidae, IArvicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arvicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10049;

    /// <inheritdoc />
    public virtual string GenusName => "Arvicola";

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
