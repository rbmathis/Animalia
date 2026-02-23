using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lepidogobius;

/// <summary>
/// Abstract class for Lepidogobius (genus).
/// NCBI TaxId: 185745
/// </summary>
public abstract class Lepidogobius : Gobiidae, ILepidogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185745;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidogobius";

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
