using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Dinogunellus;

/// <summary>
/// Abstract class for Dinogunellus (genus).
/// NCBI TaxId: 3363404
/// </summary>
public abstract class Dinogunellus : Stichaeidae, IDinogunellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinogunellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363404;

    /// <inheritdoc />
    public virtual string GenusName => "Dinogunellus";

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
