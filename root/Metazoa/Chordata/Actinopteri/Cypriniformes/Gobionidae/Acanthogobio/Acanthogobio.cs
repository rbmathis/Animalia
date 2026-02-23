using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Acanthogobio;

/// <summary>
/// Abstract class for Acanthogobio (genus).
/// NCBI TaxId: 328533
/// </summary>
public abstract class Acanthogobio : Gobionidae, IAcanthogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328533;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthogobio";

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
