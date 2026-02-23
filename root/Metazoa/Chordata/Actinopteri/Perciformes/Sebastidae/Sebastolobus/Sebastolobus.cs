using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Sebastolobus;

/// <summary>
/// Abstract class for Sebastolobus (genus).
/// NCBI TaxId: 8109
/// </summary>
public abstract class Sebastolobus : Sebastidae, ISebastolobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sebastolobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8109;

    /// <inheritdoc />
    public virtual string GenusName => "Sebastolobus";

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
