using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tolmomyias;

/// <summary>
/// Abstract class for Tolmomyias (genus).
/// NCBI TaxId: 360233
/// </summary>
public abstract class Tolmomyias : Tyrannidae, ITolmomyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tolmomyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360233;

    /// <inheritdoc />
    public virtual string GenusName => "Tolmomyias";

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
