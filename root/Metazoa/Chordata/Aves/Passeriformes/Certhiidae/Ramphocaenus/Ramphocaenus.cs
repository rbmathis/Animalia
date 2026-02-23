using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Ramphocaenus;

/// <summary>
/// Abstract class for Ramphocaenus (genus).
/// NCBI TaxId: 592665
/// </summary>
public abstract class Ramphocaenus : Certhiidae, IRamphocaenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramphocaenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 592665;

    /// <inheritdoc />
    public virtual string GenusName => "Ramphocaenus";

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
