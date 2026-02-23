using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Parapercis;

/// <summary>
/// Abstract class for Parapercis (genus).
/// NCBI TaxId: 215380
/// </summary>
public abstract class Parapercis : Pinguipedidae, IParapercis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapercis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215380;

    /// <inheritdoc />
    public virtual string GenusName => "Parapercis";

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
