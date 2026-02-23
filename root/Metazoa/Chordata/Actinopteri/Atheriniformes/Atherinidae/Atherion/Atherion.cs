using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherion;

/// <summary>
/// Abstract class for Atherion (genus).
/// NCBI TaxId: 300309
/// </summary>
public abstract class Atherion : Atherinidae, IAtherion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300309;

    /// <inheritdoc />
    public virtual string GenusName => "Atherion";

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
