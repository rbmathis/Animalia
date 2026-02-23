using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Xenospiza;

/// <summary>
/// Abstract class for Xenospiza (genus).
/// NCBI TaxId: 380368
/// </summary>
public abstract class Xenospiza : Passerellidae, IXenospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 380368;

    /// <inheritdoc />
    public virtual string GenusName => "Xenospiza";

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
