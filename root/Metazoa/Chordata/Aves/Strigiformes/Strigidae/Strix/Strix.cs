using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix;

/// <summary>
/// Abstract class for Strix (genus).
/// NCBI TaxId: 36304
/// </summary>
public abstract class Strix : Strigidae, IStrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36304;

    /// <inheritdoc />
    public virtual string GenusName => "Strix";

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
