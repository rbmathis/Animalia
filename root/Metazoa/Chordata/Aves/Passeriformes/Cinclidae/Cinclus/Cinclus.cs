using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclidae.Cinclus;

/// <summary>
/// Abstract class for Cinclus (genus).
/// NCBI TaxId: 127874
/// </summary>
public abstract class Cinclus : Cinclidae, ICinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127874;

    /// <inheritdoc />
    public virtual string GenusName => "Cinclus";

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
