using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lampridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lampridae.Lampris;

/// <summary>
/// Abstract class for Lampris (genus).
/// NCBI TaxId: 81369
/// </summary>
public abstract class Lampris : Lampridae, ILampris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lampris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81369;

    /// <inheritdoc />
    public virtual string GenusName => "Lampris";

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
