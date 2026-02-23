using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pseudaphya;

/// <summary>
/// Abstract class for Pseudaphya (genus).
/// NCBI TaxId: 441907
/// </summary>
public abstract class Pseudaphya : Gobiidae, IPseudaphya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudaphya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 441907;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudaphya";

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
