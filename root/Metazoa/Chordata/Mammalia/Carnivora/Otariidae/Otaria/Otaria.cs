using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Otaria;

/// <summary>
/// Abstract class for Otaria (genus).
/// NCBI TaxId: 161931
/// </summary>
public abstract class Otaria : Otariidae, IOtaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161931;

    /// <inheritdoc />
    public virtual string GenusName => "Otaria";

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
