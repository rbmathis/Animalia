using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Aulopus;

/// <summary>
/// Abstract class for Aulopus (genus).
/// NCBI TaxId: 81363
/// </summary>
public abstract class Aulopus : Aulopidae, IAulopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81363;

    /// <inheritdoc />
    public virtual string GenusName => "Aulopus";

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
