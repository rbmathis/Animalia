using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Serranus;

/// <summary>
/// Abstract class for Serranus (genus).
/// NCBI TaxId: 94952
/// </summary>
public abstract class Serranus : Serranidae, ISerranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94952;

    /// <inheritdoc />
    public virtual string GenusName => "Serranus";

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
