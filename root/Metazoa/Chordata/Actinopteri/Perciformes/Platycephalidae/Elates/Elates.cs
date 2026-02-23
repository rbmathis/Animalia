using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Elates;

/// <summary>
/// Abstract class for Elates (genus).
/// NCBI TaxId: 274737
/// </summary>
public abstract class Elates : Platycephalidae, IElates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274737;

    /// <inheritdoc />
    public virtual string GenusName => "Elates";

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
