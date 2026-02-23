using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Hybopsis;

/// <summary>
/// Abstract class for Hybopsis (genus).
/// NCBI TaxId: 87727
/// </summary>
public abstract class Hybopsis : Leuciscidae, IHybopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hybopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 87727;

    /// <inheritdoc />
    public virtual string GenusName => "Hybopsis";

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
