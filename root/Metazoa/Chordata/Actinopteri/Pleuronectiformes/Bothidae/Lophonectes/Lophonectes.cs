using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Lophonectes;

/// <summary>
/// Abstract class for Lophonectes (genus).
/// NCBI TaxId: 548266
/// </summary>
public abstract class Lophonectes : Bothidae, ILophonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 548266;

    /// <inheritdoc />
    public virtual string GenusName => "Lophonectes";

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
