using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microryzomys;

/// <summary>
/// Abstract class for Microryzomys (genus).
/// NCBI TaxId: 37024
/// </summary>
public abstract class Microryzomys : Cricetidae, IMicroryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37024;

    /// <inheritdoc />
    public virtual string GenusName => "Microryzomys";

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
