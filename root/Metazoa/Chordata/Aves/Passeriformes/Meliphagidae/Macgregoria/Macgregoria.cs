using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Macgregoria;

/// <summary>
/// Abstract class for Macgregoria (genus).
/// NCBI TaxId: 108829
/// </summary>
public abstract class Macgregoria : Meliphagidae, IMacgregoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macgregoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108829;

    /// <inheritdoc />
    public virtual string GenusName => "Macgregoria";

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
