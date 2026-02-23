using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Tariqilabeo;

/// <summary>
/// Abstract class for Tariqilabeo (genus).
/// NCBI TaxId: 1925552
/// </summary>
public abstract class Tariqilabeo : Cyprinidae, ITariqilabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tariqilabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1925552;

    /// <inheritdoc />
    public virtual string GenusName => "Tariqilabeo";

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
