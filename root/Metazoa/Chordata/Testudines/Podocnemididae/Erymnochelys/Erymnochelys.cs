using AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Erymnochelys;

/// <summary>
/// Abstract class for Erymnochelys (genus).
/// NCBI TaxId: 44519
/// </summary>
public abstract class Erymnochelys : Podocnemididae, IErymnochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erymnochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44519;

    /// <inheritdoc />
    public virtual string GenusName => "Erymnochelys";

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
