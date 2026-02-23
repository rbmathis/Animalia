using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblychaeturichthys;

/// <summary>
/// Abstract class for Amblychaeturichthys (genus).
/// NCBI TaxId: 497221
/// </summary>
public abstract class Amblychaeturichthys : Gobiidae, IAmblychaeturichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblychaeturichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497221;

    /// <inheritdoc />
    public virtual string GenusName => "Amblychaeturichthys";

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
