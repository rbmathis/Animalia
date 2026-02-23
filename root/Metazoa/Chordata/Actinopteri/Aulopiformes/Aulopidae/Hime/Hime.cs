using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Hime;

/// <summary>
/// Abstract class for Hime (genus).
/// NCBI TaxId: 1266827
/// </summary>
public abstract class Hime : Aulopidae, IHime
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hime";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1266827;

    /// <inheritdoc />
    public virtual string GenusName => "Hime";

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
