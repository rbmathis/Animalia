using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Sio;

/// <summary>
/// Abstract class for Sio (genus).
/// NCBI TaxId: 88715
/// </summary>
public abstract class Sio : Melamphaidae, ISio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88715;

    /// <inheritdoc />
    public virtual string GenusName => "Sio";

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
