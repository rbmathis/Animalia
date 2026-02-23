using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Protochondrostoma;

/// <summary>
/// Abstract class for Protochondrostoma (genus).
/// NCBI TaxId: 437168
/// </summary>
public abstract class Protochondrostoma : Leuciscidae, IProtochondrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protochondrostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 437168;

    /// <inheritdoc />
    public virtual string GenusName => "Protochondrostoma";

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
