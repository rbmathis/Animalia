using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sinocrossocheilus;

/// <summary>
/// Abstract class for Sinocrossocheilus (genus).
/// NCBI TaxId: 887897
/// </summary>
public abstract class Sinocrossocheilus : Cyprinidae, ISinocrossocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinocrossocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 887897;

    /// <inheritdoc />
    public virtual string GenusName => "Sinocrossocheilus";

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
