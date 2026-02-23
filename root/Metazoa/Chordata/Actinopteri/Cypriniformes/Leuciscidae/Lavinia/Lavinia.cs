using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Lavinia;

/// <summary>
/// Abstract class for Lavinia (genus).
/// NCBI TaxId: 71764
/// </summary>
public abstract class Lavinia : Leuciscidae, ILavinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lavinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71764;

    /// <inheritdoc />
    public virtual string GenusName => "Lavinia";

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
