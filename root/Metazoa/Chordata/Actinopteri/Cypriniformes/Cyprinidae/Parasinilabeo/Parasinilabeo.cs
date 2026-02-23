using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Parasinilabeo;

/// <summary>
/// Abstract class for Parasinilabeo (genus).
/// NCBI TaxId: 369675
/// </summary>
public abstract class Parasinilabeo : Cyprinidae, IParasinilabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parasinilabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369675;

    /// <inheritdoc />
    public virtual string GenusName => "Parasinilabeo";

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
