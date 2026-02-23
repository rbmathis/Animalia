using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Triso;

/// <summary>
/// Abstract class for Triso (genus).
/// NCBI TaxId: 327808
/// </summary>
public abstract class Triso : Serranidae, ITriso
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triso";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327808;

    /// <inheritdoc />
    public virtual string GenusName => "Triso";

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
