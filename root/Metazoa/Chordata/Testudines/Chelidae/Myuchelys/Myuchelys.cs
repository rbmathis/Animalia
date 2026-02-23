using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Myuchelys;

/// <summary>
/// Abstract class for Myuchelys (genus).
/// NCBI TaxId: 904236
/// </summary>
public abstract class Myuchelys : Chelidae, IMyuchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myuchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 904236;

    /// <inheritdoc />
    public virtual string GenusName => "Myuchelys";

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
