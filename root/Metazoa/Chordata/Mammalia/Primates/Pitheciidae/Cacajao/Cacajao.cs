using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Cacajao;

/// <summary>
/// Abstract class for Cacajao (genus).
/// NCBI TaxId: 30595
/// </summary>
public abstract class Cacajao : Pitheciidae, ICacajao
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cacajao";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30595;

    /// <inheritdoc />
    public virtual string GenusName => "Cacajao";

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
