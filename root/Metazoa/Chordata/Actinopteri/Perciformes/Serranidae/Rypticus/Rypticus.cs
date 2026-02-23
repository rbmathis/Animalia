using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Rypticus;

/// <summary>
/// Abstract class for Rypticus (genus).
/// NCBI TaxId: 160741
/// </summary>
public abstract class Rypticus : Serranidae, IRypticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rypticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160741;

    /// <inheritdoc />
    public virtual string GenusName => "Rypticus";

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
