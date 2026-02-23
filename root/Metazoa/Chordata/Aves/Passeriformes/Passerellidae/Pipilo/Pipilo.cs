using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Pipilo;

/// <summary>
/// Abstract class for Pipilo (genus).
/// NCBI TaxId: 40200
/// </summary>
public abstract class Pipilo : Passerellidae, IPipilo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pipilo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40200;

    /// <inheritdoc />
    public virtual string GenusName => "Pipilo";

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
