using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Palea;

/// <summary>
/// Abstract class for Palea (genus).
/// NCBI TaxId: 161717
/// </summary>
public abstract class Palea : Trionychidae, IPalea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161717;

    /// <inheritdoc />
    public virtual string GenusName => "Palea";

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
