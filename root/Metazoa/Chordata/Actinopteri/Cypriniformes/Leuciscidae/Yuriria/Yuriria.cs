using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Yuriria;

/// <summary>
/// Abstract class for Yuriria (genus).
/// NCBI TaxId: 198355
/// </summary>
public abstract class Yuriria : Leuciscidae, IYuriria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yuriria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 198355;

    /// <inheritdoc />
    public virtual string GenusName => "Yuriria";

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
