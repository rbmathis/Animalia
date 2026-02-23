using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Paranthias;

/// <summary>
/// Abstract class for Paranthias (genus).
/// NCBI TaxId: 160732
/// </summary>
public abstract class Paranthias : Serranidae, IParanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paranthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160732;

    /// <inheritdoc />
    public virtual string GenusName => "Paranthias";

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
