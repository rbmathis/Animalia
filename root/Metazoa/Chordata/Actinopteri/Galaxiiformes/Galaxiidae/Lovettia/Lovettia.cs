using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Lovettia;

/// <summary>
/// Abstract class for Lovettia (genus).
/// NCBI TaxId: 89566
/// </summary>
public abstract class Lovettia : Galaxiidae, ILovettia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lovettia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89566;

    /// <inheritdoc />
    public virtual string GenusName => "Lovettia";

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
