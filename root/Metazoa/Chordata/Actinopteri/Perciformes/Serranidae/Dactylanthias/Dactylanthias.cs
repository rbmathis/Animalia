using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Dactylanthias;

/// <summary>
/// Abstract class for Dactylanthias (genus).
/// NCBI TaxId: 3362526
/// </summary>
public abstract class Dactylanthias : Serranidae, IDactylanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactylanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362526;

    /// <inheritdoc />
    public virtual string GenusName => "Dactylanthias";

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
