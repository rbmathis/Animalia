using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Gymnocranius;

/// <summary>
/// Abstract class for Gymnocranius (genus).
/// NCBI TaxId: 182644
/// </summary>
public abstract class Gymnocranius : Lethrinidae, IGymnocranius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocranius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182644;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocranius";

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
