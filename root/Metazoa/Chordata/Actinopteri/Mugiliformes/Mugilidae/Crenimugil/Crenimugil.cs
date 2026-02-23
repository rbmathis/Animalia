using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Crenimugil;

/// <summary>
/// Abstract class for Crenimugil (genus).
/// NCBI TaxId: 143329
/// </summary>
public abstract class Crenimugil : Mugilidae, ICrenimugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crenimugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143329;

    /// <inheritdoc />
    public virtual string GenusName => "Crenimugil";

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
