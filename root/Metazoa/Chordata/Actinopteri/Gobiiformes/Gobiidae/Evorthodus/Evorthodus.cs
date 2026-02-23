using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Evorthodus;

/// <summary>
/// Abstract class for Evorthodus (genus).
/// NCBI TaxId: 186834
/// </summary>
public abstract class Evorthodus : Gobiidae, IEvorthodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Evorthodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186834;

    /// <inheritdoc />
    public virtual string GenusName => "Evorthodus";

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
