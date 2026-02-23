using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Crystallias;

/// <summary>
/// Abstract class for Crystallias (genus).
/// NCBI TaxId: 1642178
/// </summary>
public abstract class Crystallias : Liparidae, ICrystallias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crystallias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642178;

    /// <inheritdoc />
    public virtual string GenusName => "Crystallias";

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
