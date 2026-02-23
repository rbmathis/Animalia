using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Lepidocolaptes;

/// <summary>
/// Abstract class for Lepidocolaptes (genus).
/// NCBI TaxId: 75970
/// </summary>
public abstract class Lepidocolaptes : Dendrocolaptidae, ILepidocolaptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidocolaptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75970;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidocolaptes";

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
