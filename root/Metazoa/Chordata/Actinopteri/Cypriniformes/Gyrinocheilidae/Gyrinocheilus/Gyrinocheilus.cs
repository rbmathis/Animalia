using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gyrinocheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gyrinocheilidae.Gyrinocheilus;

/// <summary>
/// Abstract class for Gyrinocheilus (genus).
/// NCBI TaxId: 98398
/// </summary>
public abstract class Gyrinocheilus : Gyrinocheilidae, IGyrinocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gyrinocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98398;

    /// <inheritdoc />
    public virtual string GenusName => "Gyrinocheilus";

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
