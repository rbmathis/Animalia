using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Serpenticobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Serpenticobitidae.Serpenticobitis;

/// <summary>
/// Abstract class for Serpenticobitis (genus).
/// NCBI TaxId: 425475
/// </summary>
public abstract class Serpenticobitis : Serpenticobitidae, ISerpenticobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serpenticobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425475;

    /// <inheritdoc />
    public virtual string GenusName => "Serpenticobitis";

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
