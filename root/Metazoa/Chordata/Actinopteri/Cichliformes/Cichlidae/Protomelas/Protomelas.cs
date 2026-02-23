using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Protomelas;

/// <summary>
/// Abstract class for Protomelas (genus).
/// NCBI TaxId: 29148
/// </summary>
public abstract class Protomelas : Cichlidae, IProtomelas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protomelas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29148;

    /// <inheritdoc />
    public virtual string GenusName => "Protomelas";

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
