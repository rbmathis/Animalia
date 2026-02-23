using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Aborichthys;

/// <summary>
/// Abstract class for Aborichthys (genus).
/// NCBI TaxId: 643434
/// </summary>
public abstract class Aborichthys : Nemacheilidae, IAborichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aborichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643434;

    /// <inheritdoc />
    public virtual string GenusName => "Aborichthys";

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
