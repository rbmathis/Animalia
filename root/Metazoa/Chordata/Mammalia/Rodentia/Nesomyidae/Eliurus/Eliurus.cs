using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Eliurus;

/// <summary>
/// Abstract class for Eliurus (genus).
/// NCBI TaxId: 107273
/// </summary>
public abstract class Eliurus : Nesomyidae, IEliurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eliurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107273;

    /// <inheritdoc />
    public virtual string GenusName => "Eliurus";

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
