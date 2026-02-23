using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Meleagris;

/// <summary>
/// Abstract class for Meleagris (genus).
/// NCBI TaxId: 9102
/// </summary>
public abstract class Meleagris : Phasianidae, IMeleagris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meleagris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9102;

    /// <inheritdoc />
    public virtual string GenusName => "Meleagris";

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
