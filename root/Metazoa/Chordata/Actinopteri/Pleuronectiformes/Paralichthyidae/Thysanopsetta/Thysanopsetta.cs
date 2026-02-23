using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Thysanopsetta;

/// <summary>
/// Abstract class for Thysanopsetta (genus).
/// NCBI TaxId: 3049894
/// </summary>
public abstract class Thysanopsetta : Paralichthyidae, IThysanopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thysanopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049894;

    /// <inheritdoc />
    public virtual string GenusName => "Thysanopsetta";

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
