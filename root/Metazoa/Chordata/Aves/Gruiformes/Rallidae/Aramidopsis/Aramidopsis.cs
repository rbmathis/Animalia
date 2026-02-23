using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Aramidopsis;

/// <summary>
/// Abstract class for Aramidopsis (genus).
/// NCBI TaxId: 1150658
/// </summary>
public abstract class Aramidopsis : Rallidae, IAramidopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aramidopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150658;

    /// <inheritdoc />
    public virtual string GenusName => "Aramidopsis";

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
