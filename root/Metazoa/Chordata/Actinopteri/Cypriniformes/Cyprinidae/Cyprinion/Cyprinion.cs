using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinion;

/// <summary>
/// Abstract class for Cyprinion (genus).
/// NCBI TaxId: 137057
/// </summary>
public abstract class Cyprinion : Cyprinidae, ICyprinion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyprinion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137057;

    /// <inheritdoc />
    public virtual string GenusName => "Cyprinion";

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
