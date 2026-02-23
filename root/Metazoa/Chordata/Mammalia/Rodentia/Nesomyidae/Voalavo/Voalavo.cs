using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Voalavo;

/// <summary>
/// Abstract class for Voalavo (genus).
/// NCBI TaxId: 108516
/// </summary>
public abstract class Voalavo : Nesomyidae, IVoalavo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Voalavo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108516;

    /// <inheritdoc />
    public virtual string GenusName => "Voalavo";

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
