using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Xipholena;

/// <summary>
/// Abstract class for Xipholena (genus).
/// NCBI TaxId: 114391
/// </summary>
public abstract class Xipholena : Cotingidae, IXipholena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xipholena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114391;

    /// <inheritdoc />
    public virtual string GenusName => "Xipholena";

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
