using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Metopothrix;

/// <summary>
/// Abstract class for Metopothrix (genus).
/// NCBI TaxId: 329521
/// </summary>
public abstract class Metopothrix : Furnariidae, IMetopothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metopothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329521;

    /// <inheritdoc />
    public virtual string GenusName => "Metopothrix";

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
