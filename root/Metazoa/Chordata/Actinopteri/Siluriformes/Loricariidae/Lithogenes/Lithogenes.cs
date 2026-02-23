using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lithogenes;

/// <summary>
/// Abstract class for Lithogenes (genus).
/// NCBI TaxId: 337685
/// </summary>
public abstract class Lithogenes : Loricariidae, ILithogenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lithogenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337685;

    /// <inheritdoc />
    public virtual string GenusName => "Lithogenes";

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
