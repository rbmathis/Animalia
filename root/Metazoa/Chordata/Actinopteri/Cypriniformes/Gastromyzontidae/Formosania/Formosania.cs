using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Formosania;

/// <summary>
/// Abstract class for Formosania (genus).
/// NCBI TaxId: 7979
/// </summary>
public abstract class Formosania : Gastromyzontidae, IFormosania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Formosania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7979;

    /// <inheritdoc />
    public virtual string GenusName => "Formosania";

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
