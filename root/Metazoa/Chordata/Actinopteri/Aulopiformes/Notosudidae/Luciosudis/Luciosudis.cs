using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Notosudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Notosudidae.Luciosudis;

/// <summary>
/// Abstract class for Luciosudis (genus).
/// NCBI TaxId: 2578391
/// </summary>
public abstract class Luciosudis : Notosudidae, ILuciosudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luciosudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578391;

    /// <inheritdoc />
    public virtual string GenusName => "Luciosudis";

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
