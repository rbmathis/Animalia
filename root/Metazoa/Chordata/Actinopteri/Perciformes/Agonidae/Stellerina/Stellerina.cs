using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Stellerina;

/// <summary>
/// Abstract class for Stellerina (genus).
/// NCBI TaxId: 283638
/// </summary>
public abstract class Stellerina : Agonidae, IStellerina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stellerina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 283638;

    /// <inheritdoc />
    public virtual string GenusName => "Stellerina";

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
