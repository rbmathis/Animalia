using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Synagrops;

/// <summary>
/// Abstract class for Synagrops (genus).
/// NCBI TaxId: 107765
/// </summary>
public abstract class Synagrops : Acropomatidae, ISynagrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synagrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107765;

    /// <inheritdoc />
    public virtual string GenusName => "Synagrops";

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
