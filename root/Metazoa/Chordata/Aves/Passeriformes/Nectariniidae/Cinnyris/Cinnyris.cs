using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Cinnyris;

/// <summary>
/// Abstract class for Cinnyris (genus).
/// NCBI TaxId: 570433
/// </summary>
public abstract class Cinnyris : Nectariniidae, ICinnyris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinnyris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 570433;

    /// <inheritdoc />
    public virtual string GenusName => "Cinnyris";

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
