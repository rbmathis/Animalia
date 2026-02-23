using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Micromonacha;

/// <summary>
/// Abstract class for Micromonacha (genus).
/// NCBI TaxId: 1426923
/// </summary>
public abstract class Micromonacha : Bucconidae, IMicromonacha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micromonacha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1426923;

    /// <inheritdoc />
    public virtual string GenusName => "Micromonacha";

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
