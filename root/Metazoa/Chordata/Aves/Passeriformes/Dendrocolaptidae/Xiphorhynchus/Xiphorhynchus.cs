using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Xiphorhynchus;

/// <summary>
/// Abstract class for Xiphorhynchus (genus).
/// NCBI TaxId: 75968
/// </summary>
public abstract class Xiphorhynchus : Dendrocolaptidae, IXiphorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xiphorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75968;

    /// <inheritdoc />
    public virtual string GenusName => "Xiphorhynchus";

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
