using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Canthophrys;

/// <summary>
/// Abstract class for Canthophrys (genus).
/// NCBI TaxId: 643472
/// </summary>
public abstract class Canthophrys : Cobitidae, ICanthophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Canthophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643472;

    /// <inheritdoc />
    public virtual string GenusName => "Canthophrys";

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
