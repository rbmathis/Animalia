using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Suggrundus;

/// <summary>
/// Abstract class for Suggrundus (genus).
/// NCBI TaxId: 1188039
/// </summary>
public abstract class Suggrundus : Platycephalidae, ISuggrundus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Suggrundus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1188039;

    /// <inheritdoc />
    public virtual string GenusName => "Suggrundus";

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
