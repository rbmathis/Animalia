using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Amphispiza;

/// <summary>
/// Abstract class for Amphispiza (genus).
/// NCBI TaxId: 198937
/// </summary>
public abstract class Amphispiza : Passerellidae, IAmphispiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphispiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 198937;

    /// <inheritdoc />
    public virtual string GenusName => "Amphispiza";

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
