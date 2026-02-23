using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Abrocomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Abrocomidae.Cuscomys;

/// <summary>
/// Abstract class for Cuscomys (genus).
/// NCBI TaxId: 1567516
/// </summary>
public abstract class Cuscomys : Abrocomidae, ICuscomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cuscomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1567516;

    /// <inheritdoc />
    public virtual string GenusName => "Cuscomys";

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
