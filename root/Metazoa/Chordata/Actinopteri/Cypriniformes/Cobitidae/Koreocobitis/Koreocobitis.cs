using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Koreocobitis;

/// <summary>
/// Abstract class for Koreocobitis (genus).
/// NCBI TaxId: 457519
/// </summary>
public abstract class Koreocobitis : Cobitidae, IKoreocobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Koreocobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 457519;

    /// <inheritdoc />
    public virtual string GenusName => "Koreocobitis";

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
