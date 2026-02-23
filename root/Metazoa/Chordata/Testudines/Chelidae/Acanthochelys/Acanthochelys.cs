using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Acanthochelys;

/// <summary>
/// Abstract class for Acanthochelys (genus).
/// NCBI TaxId: 44399
/// </summary>
public abstract class Acanthochelys : Chelidae, IAcanthochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44399;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthochelys";

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
