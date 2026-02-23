using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Phacellodomus;

/// <summary>
/// Abstract class for Phacellodomus (genus).
/// NCBI TaxId: 288034
/// </summary>
public abstract class Phacellodomus : Furnariidae, IPhacellodomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phacellodomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288034;

    /// <inheritdoc />
    public virtual string GenusName => "Phacellodomus";

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
