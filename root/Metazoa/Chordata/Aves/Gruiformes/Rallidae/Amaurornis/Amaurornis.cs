using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Amaurornis;

/// <summary>
/// Abstract class for Amaurornis (genus).
/// NCBI TaxId: 72016
/// </summary>
public abstract class Amaurornis : Rallidae, IAmaurornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amaurornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72016;

    /// <inheritdoc />
    public virtual string GenusName => "Amaurornis";

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
