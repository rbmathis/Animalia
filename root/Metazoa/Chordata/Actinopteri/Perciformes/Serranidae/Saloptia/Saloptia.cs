using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Saloptia;

/// <summary>
/// Abstract class for Saloptia (genus).
/// NCBI TaxId: 327834
/// </summary>
public abstract class Saloptia : Serranidae, ISaloptia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saloptia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327834;

    /// <inheritdoc />
    public virtual string GenusName => "Saloptia";

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
