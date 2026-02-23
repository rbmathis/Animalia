using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pareiorhaphis;

/// <summary>
/// Abstract class for Pareiorhaphis (genus).
/// NCBI TaxId: 510803
/// </summary>
public abstract class Pareiorhaphis : Loricariidae, IPareiorhaphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pareiorhaphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510803;

    /// <inheritdoc />
    public virtual string GenusName => "Pareiorhaphis";

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
