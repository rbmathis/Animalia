using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembrops;

/// <summary>
/// Abstract class for Bembrops (genus).
/// NCBI TaxId: 270608
/// </summary>
public abstract class Bembrops : Perciformes, IBembrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bembrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270608;

    /// <inheritdoc />
    public virtual string GenusName => "Bembrops";

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
