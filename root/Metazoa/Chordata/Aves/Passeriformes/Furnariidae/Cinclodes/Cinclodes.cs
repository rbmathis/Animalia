using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Cinclodes;

/// <summary>
/// Abstract class for Cinclodes (genus).
/// NCBI TaxId: 279542
/// </summary>
public abstract class Cinclodes : Furnariidae, ICinclodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinclodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 279542;

    /// <inheritdoc />
    public virtual string GenusName => "Cinclodes";

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
