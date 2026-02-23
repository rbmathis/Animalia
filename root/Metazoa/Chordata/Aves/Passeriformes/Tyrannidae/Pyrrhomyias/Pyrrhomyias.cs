using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pyrrhomyias;

/// <summary>
/// Abstract class for Pyrrhomyias (genus).
/// NCBI TaxId: 495199
/// </summary>
public abstract class Pyrrhomyias : Tyrannidae, IPyrrhomyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrhomyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495199;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrhomyias";

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
