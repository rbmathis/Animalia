using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Alepidomus;

/// <summary>
/// Abstract class for Alepidomus (genus).
/// NCBI TaxId: 670420
/// </summary>
public abstract class Alepidomus : Atherinidae, IAlepidomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alepidomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 670420;

    /// <inheritdoc />
    public virtual string GenusName => "Alepidomus";

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
