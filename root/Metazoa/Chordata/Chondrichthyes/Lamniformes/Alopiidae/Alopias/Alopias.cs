using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Alopiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Alopiidae.Alopias;

/// <summary>
/// Abstract class for Alopias (genus).
/// NCBI TaxId: 7851
/// </summary>
public abstract class Alopias : Alopiidae, IAlopias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alopias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7851;

    /// <inheritdoc />
    public virtual string GenusName => "Alopias";

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
