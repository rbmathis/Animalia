using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Melanodryas;

/// <summary>
/// Abstract class for Melanodryas (genus).
/// NCBI TaxId: 254553
/// </summary>
public abstract class Melanodryas : Petroicidae, IMelanodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254553;

    /// <inheritdoc />
    public virtual string GenusName => "Melanodryas";

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
