using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae.Phodilus;

/// <summary>
/// Abstract class for Phodilus (genus).
/// NCBI TaxId: 111817
/// </summary>
public abstract class Phodilus : Tytonidae, IPhodilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phodilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111817;

    /// <inheritdoc />
    public virtual string GenusName => "Phodilus";

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
