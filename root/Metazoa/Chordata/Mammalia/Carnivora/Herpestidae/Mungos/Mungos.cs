using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Mungos;

/// <summary>
/// Abstract class for Mungos (genus).
/// NCBI TaxId: 210651
/// </summary>
public abstract class Mungos : Herpestidae, IMungos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mungos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210651;

    /// <inheritdoc />
    public virtual string GenusName => "Mungos";

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
