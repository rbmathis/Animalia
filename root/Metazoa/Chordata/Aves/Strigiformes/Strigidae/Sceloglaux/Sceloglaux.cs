using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Sceloglaux;

/// <summary>
/// Abstract class for Sceloglaux (genus).
/// NCBI TaxId: 1911055
/// </summary>
public abstract class Sceloglaux : Strigidae, ISceloglaux
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sceloglaux";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1911055;

    /// <inheritdoc />
    public virtual string GenusName => "Sceloglaux";

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
