using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Jynx;

/// <summary>
/// Abstract class for Jynx (genus).
/// NCBI TaxId: 189525
/// </summary>
public abstract class Jynx : Picidae, IJynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189525;

    /// <inheritdoc />
    public virtual string GenusName => "Jynx";

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
