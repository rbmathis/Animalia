using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pyrrhocorax;

/// <summary>
/// Abstract class for Pyrrhocorax (genus).
/// NCBI TaxId: 56788
/// </summary>
public abstract class Pyrrhocorax : Corvidae, IPyrrhocorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrhocorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56788;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrhocorax";

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
