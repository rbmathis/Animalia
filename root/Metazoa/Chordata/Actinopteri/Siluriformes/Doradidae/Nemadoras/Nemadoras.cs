using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Nemadoras;

/// <summary>
/// Abstract class for Nemadoras (genus).
/// NCBI TaxId: 245711
/// </summary>
public abstract class Nemadoras : Doradidae, INemadoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemadoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245711;

    /// <inheritdoc />
    public virtual string GenusName => "Nemadoras";

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
