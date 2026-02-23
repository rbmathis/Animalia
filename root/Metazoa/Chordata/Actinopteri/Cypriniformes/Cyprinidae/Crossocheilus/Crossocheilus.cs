using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Crossocheilus;

/// <summary>
/// Abstract class for Crossocheilus (genus).
/// NCBI TaxId: 369633
/// </summary>
public abstract class Crossocheilus : Cyprinidae, ICrossocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369633;

    /// <inheritdoc />
    public virtual string GenusName => "Crossocheilus";

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
