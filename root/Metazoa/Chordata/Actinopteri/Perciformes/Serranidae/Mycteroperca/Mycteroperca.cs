using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Mycteroperca;

/// <summary>
/// Abstract class for Mycteroperca (genus).
/// NCBI TaxId: 103819
/// </summary>
public abstract class Mycteroperca : Serranidae, IMycteroperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mycteroperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103819;

    /// <inheritdoc />
    public virtual string GenusName => "Mycteroperca";

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
