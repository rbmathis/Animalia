using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sinocyclocheilus;

/// <summary>
/// Abstract class for Sinocyclocheilus (genus).
/// NCBI TaxId: 75365
/// </summary>
public abstract class Sinocyclocheilus : Cyprinidae, ISinocyclocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinocyclocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75365;

    /// <inheritdoc />
    public virtual string GenusName => "Sinocyclocheilus";

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
