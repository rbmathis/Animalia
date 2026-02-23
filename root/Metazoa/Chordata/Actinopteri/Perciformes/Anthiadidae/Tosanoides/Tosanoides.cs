using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Tosanoides;

/// <summary>
/// Abstract class for Tosanoides (genus).
/// NCBI TaxId: 1929902
/// </summary>
public abstract class Tosanoides : Anthiadidae, ITosanoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tosanoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1929902;

    /// <inheritdoc />
    public virtual string GenusName => "Tosanoides";

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
