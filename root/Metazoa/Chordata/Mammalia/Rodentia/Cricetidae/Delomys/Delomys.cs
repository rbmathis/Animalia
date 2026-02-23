using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Delomys;

/// <summary>
/// Abstract class for Delomys (genus).
/// NCBI TaxId: 89118
/// </summary>
public abstract class Delomys : Cricetidae, IDelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89118;

    /// <inheritdoc />
    public virtual string GenusName => "Delomys";

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
