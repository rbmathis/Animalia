using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Meiglyptes;

/// <summary>
/// Abstract class for Meiglyptes (genus).
/// NCBI TaxId: 315372
/// </summary>
public abstract class Meiglyptes : Picidae, IMeiglyptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meiglyptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315372;

    /// <inheritdoc />
    public virtual string GenusName => "Meiglyptes";

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
