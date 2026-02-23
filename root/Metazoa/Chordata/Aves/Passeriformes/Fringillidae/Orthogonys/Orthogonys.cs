using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Orthogonys;

/// <summary>
/// Abstract class for Orthogonys (genus).
/// NCBI TaxId: 1271577
/// </summary>
public abstract class Orthogonys : Fringillidae, IOrthogonys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthogonys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1271577;

    /// <inheritdoc />
    public virtual string GenusName => "Orthogonys";

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
