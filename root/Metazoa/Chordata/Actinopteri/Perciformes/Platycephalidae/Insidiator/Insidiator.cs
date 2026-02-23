using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Insidiator;

/// <summary>
/// Abstract class for Insidiator (genus).
/// NCBI TaxId: 2842238
/// </summary>
public abstract class Insidiator : Platycephalidae, IInsidiator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Insidiator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2842238;

    /// <inheritdoc />
    public virtual string GenusName => "Insidiator";

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
