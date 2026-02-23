using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Ryukyupercis;

/// <summary>
/// Abstract class for Ryukyupercis (genus).
/// NCBI TaxId: 1696917
/// </summary>
public abstract class Ryukyupercis : Pinguipedidae, IRyukyupercis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ryukyupercis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1696917;

    /// <inheritdoc />
    public virtual string GenusName => "Ryukyupercis";

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
