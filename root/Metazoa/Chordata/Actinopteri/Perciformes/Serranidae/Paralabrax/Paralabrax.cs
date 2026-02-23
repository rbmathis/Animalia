using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Paralabrax;

/// <summary>
/// Abstract class for Paralabrax (genus).
/// NCBI TaxId: 30872
/// </summary>
public abstract class Paralabrax : Serranidae, IParalabrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralabrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30872;

    /// <inheritdoc />
    public virtual string GenusName => "Paralabrax";

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
