using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae.Chitala;

/// <summary>
/// Abstract class for Chitala (genus).
/// NCBI TaxId: 112144
/// </summary>
public abstract class Chitala : Notopteridae, IChitala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chitala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 112144;

    /// <inheritdoc />
    public virtual string GenusName => "Chitala";

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
