using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Megascops;

/// <summary>
/// Abstract class for Megascops (genus).
/// NCBI TaxId: 349401
/// </summary>
public abstract class Megascops : Strigidae, IMegascops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megascops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349401;

    /// <inheritdoc />
    public virtual string GenusName => "Megascops";

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
