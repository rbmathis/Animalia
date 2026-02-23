using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Belligobio;

/// <summary>
/// Abstract class for Belligobio (genus).
/// NCBI TaxId: 328522
/// </summary>
public abstract class Belligobio : Gobionidae, IBelligobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belligobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328522;

    /// <inheritdoc />
    public virtual string GenusName => "Belligobio";

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
