using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Lacedo;

/// <summary>
/// Abstract class for Lacedo (genus).
/// NCBI TaxId: 342362
/// </summary>
public abstract class Lacedo : Alcedinidae, ILacedo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lacedo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342362;

    /// <inheritdoc />
    public virtual string GenusName => "Lacedo";

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
