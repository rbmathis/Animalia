using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae.Howella;

/// <summary>
/// Abstract class for Howella (genus).
/// NCBI TaxId: 223797
/// </summary>
public abstract class Howella : Howellidae, IHowella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Howella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223797;

    /// <inheritdoc />
    public virtual string GenusName => "Howella";

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
