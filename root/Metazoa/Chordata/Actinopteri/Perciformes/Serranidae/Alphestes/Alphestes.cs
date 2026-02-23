using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Alphestes;

/// <summary>
/// Abstract class for Alphestes (genus).
/// NCBI TaxId: 160541
/// </summary>
public abstract class Alphestes : Serranidae, IAlphestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alphestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160541;

    /// <inheritdoc />
    public virtual string GenusName => "Alphestes";

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
