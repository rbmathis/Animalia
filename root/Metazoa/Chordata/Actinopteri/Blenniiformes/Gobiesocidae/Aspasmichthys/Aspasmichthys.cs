using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Aspasmichthys;

/// <summary>
/// Abstract class for Aspasmichthys (genus).
/// NCBI TaxId: 2740770
/// </summary>
public abstract class Aspasmichthys : Gobiesocidae, IAspasmichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspasmichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740770;

    /// <inheritdoc />
    public virtual string GenusName => "Aspasmichthys";

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
