using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paedovaricus;

/// <summary>
/// Abstract class for Paedovaricus (genus).
/// NCBI TaxId: 2008634
/// </summary>
public abstract class Paedovaricus : Gobiidae, IPaedovaricus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paedovaricus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2008634;

    /// <inheritdoc />
    public virtual string GenusName => "Paedovaricus";

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
