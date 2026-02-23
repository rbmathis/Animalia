using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Acanthosaura;

/// <summary>
/// Abstract class for Acanthosaura (genus).
/// NCBI TaxId: 52215
/// </summary>
public abstract class Acanthosaura : Agamidae, IAcanthosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52215;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthosaura";

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
