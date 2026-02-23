using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Markiana;

/// <summary>
/// Abstract class for Markiana (genus).
/// NCBI TaxId: 930351
/// </summary>
public abstract class Markiana : Stevardiidae, IMarkiana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Markiana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930351;

    /// <inheritdoc />
    public virtual string GenusName => "Markiana";

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
