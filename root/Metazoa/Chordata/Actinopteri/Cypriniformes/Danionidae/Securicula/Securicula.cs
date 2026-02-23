using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Securicula;

/// <summary>
/// Abstract class for Securicula (genus).
/// NCBI TaxId: 857712
/// </summary>
public abstract class Securicula : Danionidae, ISecuricula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Securicula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 857712;

    /// <inheritdoc />
    public virtual string GenusName => "Securicula";

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
