using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Melospiza;

/// <summary>
/// Abstract class for Melospiza (genus).
/// NCBI TaxId: 44395
/// </summary>
public abstract class Melospiza : Passerellidae, IMelospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44395;

    /// <inheritdoc />
    public virtual string GenusName => "Melospiza";

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
