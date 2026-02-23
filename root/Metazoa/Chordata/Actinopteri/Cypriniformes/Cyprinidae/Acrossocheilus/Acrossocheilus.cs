using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Acrossocheilus;

/// <summary>
/// Abstract class for Acrossocheilus (genus).
/// NCBI TaxId: 75335
/// </summary>
public abstract class Acrossocheilus : Cyprinidae, IAcrossocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrossocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75335;

    /// <inheritdoc />
    public virtual string GenusName => "Acrossocheilus";

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
