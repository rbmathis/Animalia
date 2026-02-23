using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherina;

/// <summary>
/// Abstract class for Atherina (genus).
/// NCBI TaxId: 87784
/// </summary>
public abstract class Atherina : Atherinidae, IAtherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 87784;

    /// <inheritdoc />
    public virtual string GenusName => "Atherina";

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
