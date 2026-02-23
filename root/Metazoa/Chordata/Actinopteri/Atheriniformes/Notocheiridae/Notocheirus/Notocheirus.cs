using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Notocheiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Notocheiridae.Notocheirus;

/// <summary>
/// Abstract class for Notocheirus (genus).
/// NCBI TaxId: 1144221
/// </summary>
public abstract class Notocheirus : Notocheiridae, INotocheirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notocheirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1144221;

    /// <inheritdoc />
    public virtual string GenusName => "Notocheirus";

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
