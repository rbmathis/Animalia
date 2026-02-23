using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Thripophaga;

/// <summary>
/// Abstract class for Thripophaga (genus).
/// NCBI TaxId: 9140
/// </summary>
public abstract class Thripophaga : Furnariidae, IThripophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thripophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9140;

    /// <inheritdoc />
    public virtual string GenusName => "Thripophaga";

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
