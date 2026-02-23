using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Petroscirtes;

/// <summary>
/// Abstract class for Petroscirtes (genus).
/// NCBI TaxId: 57846
/// </summary>
public abstract class Petroscirtes : Blenniidae, IPetroscirtes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petroscirtes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57846;

    /// <inheritdoc />
    public virtual string GenusName => "Petroscirtes";

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
