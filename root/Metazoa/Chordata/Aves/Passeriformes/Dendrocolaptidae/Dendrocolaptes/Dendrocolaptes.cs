using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Dendrocolaptes;

/// <summary>
/// Abstract class for Dendrocolaptes (genus).
/// NCBI TaxId: 81880
/// </summary>
public abstract class Dendrocolaptes : Dendrocolaptidae, IDendrocolaptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrocolaptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81880;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrocolaptes";

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
