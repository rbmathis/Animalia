using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Zapornia;

/// <summary>
/// Abstract class for Zapornia (genus).
/// NCBI TaxId: 2585821
/// </summary>
public abstract class Zapornia : Rallidae, IZapornia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zapornia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2585821;

    /// <inheritdoc />
    public virtual string GenusName => "Zapornia";

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
