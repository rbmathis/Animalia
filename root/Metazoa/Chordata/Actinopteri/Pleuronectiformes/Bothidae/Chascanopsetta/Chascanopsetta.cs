using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Chascanopsetta;

/// <summary>
/// Abstract class for Chascanopsetta (genus).
/// NCBI TaxId: 398647
/// </summary>
public abstract class Chascanopsetta : Bothidae, IChascanopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chascanopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 398647;

    /// <inheritdoc />
    public virtual string GenusName => "Chascanopsetta";

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
