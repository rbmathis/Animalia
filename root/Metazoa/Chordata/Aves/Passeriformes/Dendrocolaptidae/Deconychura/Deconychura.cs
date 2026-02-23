using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Deconychura;

/// <summary>
/// Abstract class for Deconychura (genus).
/// NCBI TaxId: 190681
/// </summary>
public abstract class Deconychura : Dendrocolaptidae, IDeconychura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deconychura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190681;

    /// <inheritdoc />
    public virtual string GenusName => "Deconychura";

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
