using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Trachyphonus;

/// <summary>
/// Abstract class for Trachyphonus (genus).
/// NCBI TaxId: 91786
/// </summary>
public abstract class Trachyphonus : Lybiidae, ITrachyphonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachyphonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91786;

    /// <inheritdoc />
    public virtual string GenusName => "Trachyphonus";

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
